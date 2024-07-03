package com.example.paptelemovel;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.graphics.Color;
import android.os.Bundle;
import android.provider.MediaStore;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.google.android.material.snackbar.Snackbar;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.Calendar;
import java.util.Date;
import java.util.HashMap;
import java.util.Map;

public class AdicionarOcorrencia extends AppCompatActivity {
    private static final int REQUEST_IMAGE_CAPTURE = 1;
    private static final int REQUEST_PERMISSION = 100;
    private RequestQueue requestQueue;
    private Bitmap imageBitmap;
    private TextView voltar;
    private EditText motivo;
    private EditText descricao;
    private EditText matricula;
    private Button enviar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_adicionar_ocorrencia);

        // Check for camera permission
        if (ContextCompat.checkSelfPermission(this, Manifest.permission.CAMERA) != PackageManager.PERMISSION_GRANTED) {
            ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.CAMERA}, REQUEST_PERMISSION);
        } else {
            // Permission already granted
            dispatchTakePictureIntent();
        }
        enviar = (Button) findViewById(R.id.btnEnviar);
        motivo = (EditText) findViewById(R.id.txtMotivo);
        descricao = (EditText) findViewById(R.id.txtDescricao);
        matricula = (EditText) findViewById(R.id.txtMatricula);


    }
    public void clicaEnviar(View view) throws IOException {
        String matriculaTxt;
        if(motivo.getText().toString().equals("") || motivo.getText() == null){
            Toast.makeText(view.getContext(), "Insira o motido a ocorrência (Algo minimalista)", Toast.LENGTH_LONG).show();
            return;
        }
        if(descricao.getText().toString().equals("") || descricao.getText() == null ){
            Toast.makeText(view.getContext(), "Insira o que aconteceu na ocorrência", Toast.LENGTH_SHORT).show();
            return;
        }
        if(matricula.getText() == null){
            matriculaTxt = "";
        }else{
            matriculaTxt = matricula.getText().toString();
        }

        byte[] byteArray = bitmapToByteArray(imageBitmap);

        String hexString = byteArrayToHexString(byteArray);
        SimpleDateFormat formatter = new SimpleDateFormat("yyyy-MM-dd");
        Date date = new Date();
        String url = bd.ip+ "adicionarOcorrencias/?api_key=" + MainActivity.api_key + "&nif=" + Integer.parseInt(MainActivity.nifLogado.toString()) +"&motivo="+ motivo.getText().toString()+ "&descricao="+ descricao.getText().toString() + "&data="+ formatter.format(date)+ "&matricula="+matriculaTxt;
        requestQueue = Volley.newRequestQueue(this);
        StringRequest stringRequest = new StringRequest(Request.Method.POST, url,
                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {
                    }
                }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                // Handle error response
                // Toast.makeText(MainActivity.this, "Error: " + error.getMessage(), Toast.LENGTH_SHORT).show();
            }
        }) {
            @Override
            protected Map<String, String> getParams() {
                Map<String, String> params = new HashMap<>();
                params.put("foto", hexString);
                return params;
            }
        };

        // Add the request to the RequestQueue
        requestQueue.add(stringRequest);

        this.finish();
    }

    private void dispatchTakePictureIntent() {
        Intent takePictureIntent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
        if (takePictureIntent.resolveActivity(getPackageManager()) != null) {
            startActivityForResult(takePictureIntent, REQUEST_IMAGE_CAPTURE);
        }
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        try {

            if (requestCode == REQUEST_IMAGE_CAPTURE && resultCode == RESULT_OK) {
                Bundle extras = data.getExtras();
                if (extras != null) {
                    imageBitmap = (Bitmap) extras.get("data");
                    ImageView imageView = findViewById(R.id.imageView);
                    imageView.setImageBitmap(imageBitmap);
                } else {
                    Toast.makeText(this, "erro novo", Toast.LENGTH_SHORT).show();

                }
            }
        }catch (Exception e){
            Toast.makeText(this, e.getMessage(), Toast.LENGTH_SHORT).show();
        }
    }

    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults) {
        super.onRequestPermissionsResult(requestCode, permissions, grantResults);
        if (requestCode == REQUEST_PERMISSION) {
            if (grantResults.length > 0 && grantResults[0] == PackageManager.PERMISSION_GRANTED) {
                dispatchTakePictureIntent();
            } else {
                Toast.makeText(this, "A permissão de camera é necessária para tirar fotos", Toast.LENGTH_SHORT).show();
            }
        }
    }
    public static byte[] bitmapToByteArray(Bitmap bitmap) {
        ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
        bitmap.compress(Bitmap.CompressFormat.PNG, 100, byteArrayOutputStream);
        return byteArrayOutputStream.toByteArray();
    }

    // Convert byte array to hex string
    public static String byteArrayToHexString(byte[] byteArray) {
        StringBuilder hexString = new StringBuilder();
        for (byte b : byteArray) {
            String hex = Integer.toHexString(0xFF & b);
            if (hex.length() == 1) {
                hexString.append('0');
            }
            hexString.append(hex);
        }
        return hexString.toString();
    }
}
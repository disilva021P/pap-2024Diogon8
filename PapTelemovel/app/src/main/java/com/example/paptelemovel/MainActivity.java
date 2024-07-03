package com.example.paptelemovel;

import androidx.appcompat.app.AppCompatActivity;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Color;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;

import java.io.IOException;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.Volley;
import com.google.android.material.snackbar.Snackbar;
import org.json.JSONException;
import org.json.JSONObject;

public class MainActivity extends AppCompatActivity {
    static public Integer nifLogado;
    private RequestQueue requestQueue;
    static public String api_key = "PALAVRAPASSULTRASECRETA:O!okjachega";
    private TextView msgErro;
    private EditText nif;
    private EditText pass;
    private RadioButton rbManterLogado;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        SharedPreferences sharedPreferences = getSharedPreferences("loginPrefs", Context.MODE_PRIVATE);
        String username = sharedPreferences.getString("nif", "");
        String password = sharedPreferences.getString("password", "");
        if (!TextUtils.isEmpty(username) && !TextUtils.isEmpty(password)) {
            nifLogado = Integer.parseInt(username);
            Intent segundaTela = new Intent(MainActivity.this, UtilizadorGeral.class);
            startActivity(segundaTela);
        } else {
            setContentView(R.layout.activity_main);
            nif = (EditText) findViewById(R.id.txtNif);
            pass = (EditText) findViewById(R.id.txtPassword);
            rbManterLogado = (RadioButton)  findViewById(R.id.rbManterLogado);
        }


    }
    public void clicaEntrar(View view) throws IOException {
        get(view);
    }
    public void get(View view){
        String url = bd.ip+ "loginUtilizadores/?api_key="+ api_key + "&nif="+ nif.getText().toString() +"&pass='"+ pass.getText().toString() + "'";
        requestQueue = Volley.newRequestQueue(this);

        // Fazer a solicitação HTTP
        JsonObjectRequest jsonObjectRequest = new JsonObjectRequest(
                Request.Method.GET,
                url,
                null,
                new Response.Listener<JSONObject>() {
                    @Override
                    public void onResponse(JSONObject response) {
                        try {
                            if(response.getBoolean("entra")){
                                if(rbManterLogado.isChecked()){
                                    SharedPreferences sharedPreferences = getSharedPreferences("loginPrefs", Context.MODE_PRIVATE);
                                    SharedPreferences.Editor editor = sharedPreferences.edit();
                                    editor.putString("nif", nif.getText().toString());
                                    editor.putString("password", nif.getText().toString());
                                    editor.apply();
                                    nifLogado = Integer.parseInt(nif.getText().toString());
                                    Intent segundaTela = new Intent(MainActivity.this, UtilizadorGeral.class);
                                    startActivity(segundaTela);

                                }else{
                                    nifLogado = Integer.parseInt(nif.getText().toString());
                                    Intent segundaTela = new Intent(MainActivity.this, UtilizadorGeral.class);
                                    startActivity(segundaTela);
                                }

                            }else{
                                Snackbar snackbar = Snackbar.make(view, "Erro! User não encontrado.", Snackbar.LENGTH_SHORT);
                                snackbar.setTextColor(Color.RED); // Definir a cor do texto
                                snackbar.show();                            }

                        } catch (JSONException e) {
                            throw new RuntimeException(e);
                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        // Lidar com erros de requisição aqui
                    }
                }
        );

        // Adicionar a solicitação à fila de solicitações
        requestQueue.add(jsonObjectRequest);

    }



}
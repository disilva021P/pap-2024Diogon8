package com.example.paptelemovel;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONException;
import org.json.JSONObject;

public class AddCarro extends AppCompatActivity {

    private Button btnVoltar;
    private Button btnAdicionar;
    private TextView txtmatricula;
    private TextView txtmarca;
    private RequestQueue requestQueue;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_carro);

        btnVoltar = (Button) findViewById(R.id.btnVoltarMenu) ;
        btnAdicionar = (Button) findViewById(R.id.btnAdicionarRequest) ;
        txtmatricula = (TextView) findViewById(R.id.txtMatriculaEnviar);
        txtmarca = (TextView) findViewById(R.id.txtMarcaEnviar) ;

        btnVoltar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                fechar();
            }
        });
        btnAdicionar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if(txtmatricula.getText().toString().equals("") || txtmatricula.getText().length()!=6){
                    Toast.makeText(getApplicationContext(),"Tem que inserir uma matricula valida!",Toast.LENGTH_LONG).show();
                }else{
                    String marca= txtmarca.getText().toString().equals("") ? null : txtmarca.getText().toString();
                    enviarRequest(txtmatricula.getText().toString().toUpperCase(),txtmarca.getText().toString());
                }
            }
        });
    }
    private void fechar(){
        this.finish();
    }
    private void enviarRequest(String matricula,String marca) {
        RequestQueue requestQueue = Volley.newRequestQueue(this);
        String url = bd.ip+ "adicionarCarros/?api_key=" + MainActivity.api_key + "&nif="+MainActivity.nifLogado +"&matricula=" + matricula+"&marca="+marca ;

        JsonObjectRequest jsonObject = new JsonObjectRequest(
                Request.Method.GET, url, null,
                new Response.Listener<JSONObject>() {
                    @Override
                    public void onResponse(JSONObject response) {

                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        error.printStackTrace();
                    }
                });

        requestQueue.add(jsonObject);
        fechar();
    }

}
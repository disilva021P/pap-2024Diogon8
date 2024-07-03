package com.example.paptelemovel;

import static androidx.core.content.ContentProviderCompat.requireContext;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.graphics.Color;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

public class Pagamento extends AppCompatActivity {

    public String link;
    public bd.Pagamento p;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pagamento);
        Intent intent = getIntent();
        int id = intent.getIntExtra("id", 0);
        p = Pagamentos.pagamentosList.get(id);
        Button btnPagar = findViewById(R.id.btnPagar);
        RequestPagamento();
        System.out.println(link);
        btnPagar.setOnClickListener(new View.OnClickListener()
            {
                @Override
                public void onClick (View view){
                    String url = link;
                    Intent intent = new Intent(Intent.ACTION_VIEW);
                    intent.setData(Uri.parse(url));
                    startActivity(intent);
                }
            });


    }

    private void RequestPagamento() {
        RequestQueue requestQueue = Volley.newRequestQueue(this);
        String url = bd.ip+ "pagamentoLink/?api_key=" + MainActivity.api_key + "&id=" + p.getId();

        JsonObjectRequest jsonObject = new JsonObjectRequest(
                Request.Method.GET, url, null,
                new Response.Listener<JSONObject>() {
                    @Override
                    public void onResponse(JSONObject response) {
                        try {
                            link = response.getString("link");
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        error.printStackTrace();
                    }
                });

        requestQueue.add(jsonObject);
    }

    public void clickVoltar(){
        this.finish();
    }
}
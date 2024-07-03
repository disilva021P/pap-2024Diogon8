package com.example.paptelemovel;

import static androidx.core.content.ContextCompat.getSystemService;

import android.app.Notification;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.graphics.Color;
import android.os.Build;
import android.os.Bundle;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;

import androidx.core.app.ActivityCompat;
import androidx.core.app.NotificationCompat;
import androidx.core.app.NotificationManagerCompat;
import androidx.fragment.app.Fragment;

import android.os.Handler;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

public class Lugar extends Fragment {
    public static String ocupacao= "Desocupado";
        private Handler handler = new Handler();
        private Runnable runnable;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        runnable = new Runnable() {
            @Override
            public void run() {
                Request();


                // Agende a execução do próximo ciclo
                handler.postDelayed(this, 5000);
            }
        };
        handler.post(runnable);
        return inflater.inflate(R.layout.fragment_lugar, container, false);
    }
    @Override
    public void onDestroyView() {
        super.onDestroyView();
        // Pare a execução do handler quando a Fragment for destruída para evitar vazamento de memória
        handler.removeCallbacks(runnable);
    }
    private void Request() {
        RequestQueue requestQueue = Volley.newRequestQueue(requireContext());
        String url = bd.ip+ "lugar/?api_key=" + MainActivity.api_key + "&nif=" + Integer.parseInt(MainActivity.nifLogado.toString());

        JsonArrayRequest jsonArrayRequest = new JsonArrayRequest(
                Request.Method.GET, url, null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        try {
                            JSONObject jsonObject = response.getJSONObject(0);
                            String lugar = String.valueOf(jsonObject.getInt("lugar"));
                            String ocupacaoRecebida =  jsonObject.getString("ocupacao");
                            ((TextView) getView().findViewById(R.id.txtLugar)).setText(lugar);

                            // Verifique se o valor recebido é 0
                            if (ocupacao.equals("Desocupado") && ocupacaoRecebida.equals("Ocupado")) {
                                ocupacao= "Ocupado";
                                ((TextView) getView().findViewById(R.id.txtOcupacao)).setTextColor(Color.RED);

                            }
                            else if(ocupacao.equals("Ocupado") && ocupacaoRecebida.equals("Desocupado")){
                                ocupacao= "Desocupado";
                                ((TextView) getView().findViewById(R.id.txtOcupacao)).setTextColor(Color.GREEN);

                            }
                            ((TextView) getView().findViewById(R.id.txtOcupacao)).setText(ocupacao);

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

        requestQueue.add(jsonArrayRequest);
    }

}
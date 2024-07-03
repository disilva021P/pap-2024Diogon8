package com.example.paptelemovel;

import android.content.Intent;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;


public class Pagamentos extends Fragment {
    private LinearLayout tableLayout;
    private RequestQueue requestQueue;
    public static List<bd.Pagamento> pagamentosList = new ArrayList<>();

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View rootView = inflater.inflate(R.layout.fragment_pagamentos, container, false);
        tableLayout = (LinearLayout) rootView.findViewById(R.id.tableLayoutCarros);
        // Simulação de dados de pagamento
        getPagamentos();

        // Adicionando os dados à tabela
        return rootView;

    }
    private void addPagamentoToTable(bd.Pagamento pagamento) {
        // Criando uma nova linha na tabela (LinearLayout horizontal)
        LinearLayout rowLayout = new LinearLayout(getActivity());
        rowLayout.setLayoutParams(new LinearLayout.LayoutParams(
                LinearLayout.LayoutParams.MATCH_PARENT,
                LinearLayout.LayoutParams.WRAP_CONTENT));
        rowLayout.setOrientation(LinearLayout.HORIZONTAL);
        rowLayout.setId(pagamento.getId());

        // Adicionando TextViews com os dados do pagamento à linha
        TextView nomePagadorTextView = createTextView(pagamento.getTitulo());
        TextView quantidadeTextView = createTextView(String.valueOf(pagamento.getValor()));
        TextView dataTextView = createTextView(pagamento.getData());
        TextView estado = createTextView(pagamento.getEstado());

        rowLayout.addView(nomePagadorTextView);
        rowLayout.addView(quantidadeTextView);
        rowLayout.addView(dataTextView);
        rowLayout.addView(estado);
        rowLayout.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Ação a ser executada quando a linha for clicada
                // Por exemplo, você pode abrir uma nova atividade, exibir um diálogo, etc.
                if(pagamento.getEstado().equals("Por Pagar")){
                    Intent pagamentoEcra = new Intent(requireActivity(), Pagamento.class);
                    pagamentoEcra.putExtra("id", pagamentosList.indexOf(pagamento));
                    startActivity(pagamentoEcra);
                }else{
                    Toast.makeText(getContext(), "Já pagou!", Toast.LENGTH_SHORT).show();
                }

            }
        });
        // Adicionando a linha à tabela
        tableLayout.addView(rowLayout);
    }

    // Método auxiliar para criar TextViews
    private TextView createTextView(String text) {
        TextView textView = new TextView(getActivity());
        textView.setLayoutParams(new LinearLayout.LayoutParams(
                0,
                LinearLayout.LayoutParams.WRAP_CONTENT, 1));
        textView.setText(text);
        return textView;
    }

    public void getPagamentos() {
        String url = bd.ip+ "getPagamentos/?api_key=" + MainActivity.api_key + "&nif=" + Integer.parseInt(MainActivity.nifLogado.toString());
        requestQueue = Volley.newRequestQueue(requireActivity());


        JsonArrayRequest jsonArrayRequest = new JsonArrayRequest(
                Request.Method.GET,
                url,
                null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        try {
                            for (int i = 0; i < response.length(); i++) {
                                try {
                                    JSONObject jsonObject = response.getJSONObject(i);
                                    int id = jsonObject.getInt("id");
                                    String titulo = jsonObject.getString("titulo");
                                    String data = jsonObject.getString("data");
                                    double valor = jsonObject.getDouble("valor");
                                    int estado = jsonObject.getInt("estado");
                                    bd.Pagamento pagamento = new bd.Pagamento(id,titulo, valor, data, estado);
                                    pagamentosList.add(pagamento);
                                    addPagamentoToTable(pagamento);
                                } catch (JSONException e) {
                                    e.printStackTrace();
                                }
                            }
                        } catch (Exception e) {
                            e.printStackTrace();
                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Toast.makeText(getContext(), error.getMessage(), Toast.LENGTH_SHORT).show();
                    }
                }
        );
        requestQueue.add(jsonArrayRequest);
    }

}
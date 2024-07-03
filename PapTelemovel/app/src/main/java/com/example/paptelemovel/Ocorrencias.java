package com.example.paptelemovel;

import android.content.Intent;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.os.Handler;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

public class Ocorrencias extends Fragment {
    private LinearLayout tableLayout;
    private RequestQueue requestQueue;
    private Button adicionarBtn;
    private Handler handler = new Handler();
    private Runnable runnable;
    private List<bd.Ocorrencia> ocorrenciasList = new ArrayList<>();
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View rootView = inflater.inflate(R.layout.fragment_ocorrencias, container, false);
        tableLayout = (LinearLayout) rootView.findViewById(R.id.tableLayoutOcorrencias);
        getOcorrencia();

        adicionarBtn = (Button) rootView.findViewById(R.id.btnAdicionarOcorrencia);
        adicionarBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                        clickAdicionar();
                    }});



        return rootView;
    }

    private void addOcorrenciaToTable(bd.Ocorrencia ocorrencia) {
        // Criando uma nova linha na tabela (LinearLayout horizontal)
        LinearLayout rowLayout = new LinearLayout(getActivity());
        rowLayout.setLayoutParams(new LinearLayout.LayoutParams(
                LinearLayout.LayoutParams.MATCH_PARENT,
                LinearLayout.LayoutParams.WRAP_CONTENT));
        rowLayout.setOrientation(LinearLayout.HORIZONTAL);
        rowLayout.setId(ocorrencia.getId());
        // Adicionando TextViews com os dados do pagamento à linha
        TextView dataOcorrencia = createTextView(ocorrencia.getData());
        TextView motivoTextView = createTextView(String.valueOf(ocorrencia.getMotivo()));
        TextView descricaoTextView = createTextView(ocorrencia.getDescricao());
        rowLayout.addView(dataOcorrencia);
        rowLayout.addView(motivoTextView);
        rowLayout.addView(descricaoTextView);
        rowLayout.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

            }
        });
        tableLayout.addView(rowLayout);
    }

    private TextView createTextView(String text) {
        TextView textView = new TextView(getActivity());
        textView.setLayoutParams(new LinearLayout.LayoutParams(
                0,
                LinearLayout.LayoutParams.WRAP_CONTENT, 1));
        textView.setText(text);
        return textView;
    }

    public void getOcorrencia() {
        String url = bd.ip+ "getOcorrencias/?api_key=" + MainActivity.api_key + "&nif=" + Integer.parseInt(MainActivity.nifLogado.toString());
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
                                    String motivo = jsonObject.getString("motivo");
                                    String descricao = jsonObject.getString("descricao");
                                    String data = jsonObject.getString("dataOcorrencia");
                                    String fotoHex = jsonObject.optString("foto");
                                    byte[] foto = hexStringToByteArray(fotoHex);
                                    String matricula = jsonObject.getString("matricula");
                                    int idEstadoOcorrencia = jsonObject.getInt("idEstadoOcorrencia");

                                    bd.Ocorrencia ocorrencia = new bd.Ocorrencia(id, motivo, descricao, data, foto, matricula, idEstadoOcorrencia);
                                    ocorrenciasList.add(ocorrencia);
                                    addOcorrenciaToTable(ocorrencia);
                                } catch (JSONException e) {
                                    e.printStackTrace();
                                    Toast.makeText(getContext(), e.getMessage(), Toast.LENGTH_SHORT).show();

                                }
                            }
                        } catch (Exception e) {
                            e.printStackTrace();
                            Toast.makeText(getContext(), e.getMessage(), Toast.LENGTH_SHORT).show();

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
    public static byte[] hexStringToByteArray(String s) {
        int len = s.length();
        byte[] data = new byte[len / 2];
        for (int i = 0; i < len; i += 2) {
            data[i / 2] = (byte) ((Character.digit(s.charAt(i), 16) << 4)
                    + Character.digit(s.charAt(i + 1), 16));
        }
        return data;
    }
    public void clickAdicionar(){
        Intent intent = new Intent(requireActivity(), AdicionarOcorrencia.class);
        startActivity(intent);
    }
}
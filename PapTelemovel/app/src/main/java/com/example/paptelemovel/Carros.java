package com.example.paptelemovel;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.LinearLayout;
import android.widget.TableLayout;
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

import java.util.ArrayList;
import java.util.List;

public class Carros extends Fragment {
    private LinearLayout tableLayout;

    private RequestQueue requestQueue;
    private List<CheckBox> checkBoxes = new ArrayList<>();
    private int idcarroSelecionado;
    private Button btnRemover;
    private Button btnAdicionar;
    private int contar;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View rootView = inflater.inflate(R.layout.fragment_carros, container, false);
        contar=0;
        tableLayout = (LinearLayout) rootView.findViewById(R.id.tableLayoutCarros);
        btnRemover = (Button) rootView.findViewById(R.id.btnRemoverCarro);
        btnAdicionar = (Button) rootView.findViewById(R.id.btnAdicionarCarro);
        btnRemover.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                removerCarro();
            }
        });
        getCarros();

        return rootView;

    }
    private void removerCarro(){
        AlertDialog.Builder builder = new AlertDialog.Builder(getContext());
        builder.setTitle("Confirmação");
        builder.setMessage("Tem certeza que deseja prosseguir?");

        builder.setPositiveButton("Sim", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                String url = bd.ip+ "removerCarros/?api_key=" + MainActivity.api_key + "&nif="+MainActivity.nifLogado +"&idCarro=" + idcarroSelecionado ;

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
            }
        });

        builder.setNegativeButton("Não", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.dismiss();
            }
        });

        AlertDialog dialog = builder.create();
        dialog.show();
    }
    private void adicionarCarro(){
        Intent addcarro = new Intent(requireActivity(), AddCarro.class);
        startActivity(addcarro);
    }
    private void addCarroTabela(bd.Carro carro) {
        ++contar;
        if (contar < 3){
            btnAdicionar.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    adicionarCarro();
                }
            });
            btnAdicionar.setVisibility(View.VISIBLE);
        }else{
            btnAdicionar.setVisibility(View.INVISIBLE);
        }
        // Criando uma nova linha na tabela (LinearLayout horizontal)
        LinearLayout rowLayout = new LinearLayout(getActivity());
        rowLayout.setLayoutParams(new LinearLayout.LayoutParams(
                LinearLayout.LayoutParams.MATCH_PARENT,
                LinearLayout.LayoutParams.WRAP_CONTENT));
        rowLayout.setOrientation(LinearLayout.HORIZONTAL);
        rowLayout.setId(carro.getId()

        );


        // Adicionando CheckBox à linha
        CheckBox checkBox = new CheckBox(getActivity());
        checkBox.setId(carro.getId());
        checkBox.setLayoutParams(new LinearLayout.LayoutParams(
                0,

                LinearLayout.LayoutParams.WRAP_CONTENT, 1));
        rowLayout.addView(checkBox);
        checkBox.setOnCheckedChangeListener((buttonView, isChecked) -> {

                    if (isChecked) {
                        for (CheckBox cb : checkBoxes) {
                            if (cb.isChecked() && !cb.equals(checkBox)) {
                                cb.setChecked(false);
                            }
                        }
                        idcarroSelecionado = checkBox.getId();
                        btnRemover.setVisibility(View.VISIBLE);

                    }else{
                        idcarroSelecionado=-1;
                        btnRemover.setVisibility(View.INVISIBLE);
                    }
                });
        checkBoxes.add(checkBox);
        TextView matricula = createTextView(carro.getMatricula());

        rowLayout.addView(matricula);
        TextView marca = createTextView(carro.getMarca());

        rowLayout.addView(marca );

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
    public void getCarros() {
        String url = bd.ip+ "getCarros/?api_key=" + MainActivity.api_key + "&nif=" + Integer.parseInt(MainActivity.nifLogado.toString());
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
                                    String matricula = jsonObject.getString("matricula");
                                    String marca = jsonObject.getString("marca");
                                    bd.Carro carro = new bd.Carro(id,matricula, marca);
                                    addCarroTabela(carro);
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
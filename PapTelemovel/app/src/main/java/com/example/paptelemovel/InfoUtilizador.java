package com.example.paptelemovel;

import static com.example.paptelemovel.Ocorrencias.hexStringToByteArray;

import android.graphics.BitmapFactory;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
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


public class InfoUtilizador extends Fragment {


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View rootView = inflater.inflate(R.layout.fragment_info_utilizador, container, false);
        preencherInfos(rootView);
        return rootView;
    }
    private void preencherInfos(View v){
        RequestQueue requestQueue;
        String url = bd.ip+ "getInfo/?api_key=" + MainActivity.api_key + "&nif=" + Integer.parseInt(MainActivity.nifLogado.toString());
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
                                    ((TextView) v.findViewById(R.id.nif)).setText(String.valueOf(MainActivity.nifLogado));
                                    ((TextView) v.findViewById(R.id.txtNome)).setText( jsonObject.getString("nome"));
                                    ((TextView) v.findViewById(R.id.txtMorada)).setText(jsonObject.getString("morada"));
                                    ((TextView) v.findViewById(R.id.txtEmail)).setText(jsonObject.getString("email"));
                                    String fotoHex = jsonObject.optString("foto");
                                    byte[] foto = hexStringToByteArray(fotoHex);
                                    ((ImageView) v.findViewById(R.id.foto)).setImageBitmap(BitmapFactory.decodeByteArray(foto, 0, foto.length));
                                    ((TextView) v.findViewById(R.id.txtDataNascimento)).setText(jsonObject.getString("dataNascimento"));
                                    ((TextView) v.findViewById(R.id.txtNumero)).setText(jsonObject.getString("numero"));
                                    ((TextView) v.findViewById(R.id.txtNOcorrencia)).setText(String.valueOf(jsonObject.getInt("nocorrencias")));
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
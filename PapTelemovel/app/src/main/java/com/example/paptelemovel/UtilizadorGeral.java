package com.example.paptelemovel;

import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.FragmentPagerAdapter;
import androidx.viewpager.widget.ViewPager;

import android.os.Bundle;

import com.android.volley.VolleyError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;
import com.google.android.material.tabs.TabLayout;

import org.json.JSONArray;
import org.json.JSONException;

public class UtilizadorGeral extends AppCompatActivity {

    private TabLayout tabLayout;
    private ViewPager viewPagina;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_utilizador_geral);
        tabLayout = findViewById(R.id.tabLayout);
        viewPagina = findViewById(R.id.Pagina);
        VPAdapter vpAdapter = new VPAdapter(getSupportFragmentManager(), FragmentPagerAdapter.BEHAVIOR_RESUME_ONLY_CURRENT_FRAGMENT);
        vpAdapter.addFragment(new InfoUtilizador(), "Minha Info");
        vpAdapter.addFragment(new Carros(), "Carros");
        vpAdapter.addFragment(new Ocorrencias(), "Ocorrencias");
        RequestQueue requestQueue = Volley.newRequestQueue(this);
        JsonArrayRequest jsonArrayRequest = new JsonArrayRequest(
                Request.Method.GET, bd.ip+ "confs/?api_key=PALAVRAPASSULTRASECRETA:O!okjachega", null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        try {
                            JSONArray innerArray = response.getJSONArray(0);

                            int element1 = innerArray.getInt(0);
                            int element2 = innerArray.getInt(1);
                            if (element1 == 1) {
                                vpAdapter.addFragment(new Pagamentos(), "Pagamentos");
                            }
                            if (element2 == 1) {
                                vpAdapter.addFragment(new Lugar(), "Lugar");
                            }
                            vpAdapter.addFragment(new logout(), "Logout");
                            vpAdapter.notifyDataSetChanged();

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
        viewPagina.setAdapter(vpAdapter);
        tabLayout.setupWithViewPager(viewPagina);
        ConstraintLayout.LayoutParams layoutParams = (ConstraintLayout.LayoutParams) viewPagina.getLayoutParams();
        viewPagina.setPageMargin(0);
    }
}
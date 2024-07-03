package com.example.paptelemovel;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;

import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;
import com.google.android.material.tabs.TabLayout;

import androidx.fragment.app.FragmentPagerAdapter;
import androidx.viewpager.widget.ViewPager;
import androidx.appcompat.app.AppCompatActivity;
import androidx.viewpager2.widget.ViewPager2;

import android.view.Menu;
import android.view.MenuItem;
import android.view.View;


public class TelaUtilizador extends AppCompatActivity {


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        //fab.setOnClickListener(new View.OnClickListener() {
      //    @Override
        //    public void onClick(View view) {
        //        SharedPreferences sharedPreferences = getSharedPreferences("loginPrefs", Context.MODE_PRIVATE);
        //        SharedPreferences.Editor editor = sharedPreferences.edit();
        //        editor.clear();
        //        editor.apply();
        //        MainActivity.nifLogado = -1;
        //        Intent segundaTela = new Intent(TelaUtilizador.this, MainActivity.class);
        //        startActivity(segundaTela);
        //    }
        //});
    }
}
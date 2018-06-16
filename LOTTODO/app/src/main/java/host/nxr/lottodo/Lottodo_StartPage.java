package host.nxr.lottodo;

import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v7.app.AppCompatActivity;
import android.view.View;

/**
 * Created by ELNINOXAVIER on 5/27/2017.
 */

public class Lottodo_StartPage extends AppCompatActivity {
    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lottodo_startpage);
    }
public void createAccount(View view){
    Intent createAccountIntent=new Intent(this,Lottodo_CreateAccount.class);
    startActivity(createAccountIntent);
}
}

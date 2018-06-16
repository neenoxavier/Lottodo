package host.nxr.lottodo;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Patterns;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import host.nxr.lottodo.models.UserDetails;
import host.nxr.lottodo.services.LottodoCustomListener;
import host.nxr.lottodo.services.LottodoServices;

import static android.widget.Toast.LENGTH_SHORT;

public class Lottodo_CreateAccount extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        LottodoServices.getInstance(this);
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lottodo_create_account);
    }
    public void CreateAccount(View view){

        EditText txt_fullname=(EditText)findViewById(R.id.txt_fullname);
        EditText txt_email=(EditText)findViewById(R.id.txt_email);
        EditText txt_password=(EditText)findViewById(R.id.txt_password);

        if(!PerformValidation(txt_fullname,txt_email,txt_password))
            return;
        UserDetails userDetails=new UserDetails();
        userDetails.ltd_FullName=txt_fullname.getText().toString();
        userDetails.ltd_Email=txt_email.getText().toString();
        userDetails.ltd_Password=txt_password.getText().toString();
        userDetails.ltd_FBConnected=false;
        LottodoServices.getInstance().CreateAccount(userDetails,new LottodoCustomListener<String>(){
            @Override
            public void getResult(String result)
            {
                if (!result.isEmpty())
                {
                    Toast toast=Toast.makeText(getApplicationContext(),result,LENGTH_SHORT);
                    //do what you need with the result...
                }
            }
        });
    }

    public boolean PerformValidation(EditText txt_fullname,EditText txt_email,EditText txt_password){

        if(txt_fullname.getText().toString().length()==0){
            txt_fullname.setError("First Name is required");
            return false;
        }
        if(txt_email.getText().toString().length()==0){
            txt_email.setError("Email Address is required");
            return false;
        }
        if(!Patterns.EMAIL_ADDRESS.matcher(txt_email.getText().toString()).matches()){
            txt_email.setError("Email Address is invalid");
            return false;
        }
        if(txt_password.getText().toString().length()==0){
            txt_password.setError("Password is required");
            return false;
        }
        if(txt_password.getText().toString().length()<5){
            txt_password.setError("Password is too weak");
            return false;
        }

        return true;
    }
}

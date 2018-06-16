package host.nxr.lottodo.services;

import android.content.Context;
import android.util.Log;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONObject;

import java.util.HashMap;
import java.util.Map;

/**
 * Created by ELNINOXAVIER on 7/19/2017.
 */

public class LottodoServices {
    private static final String TAG = "LottodoServices";
    private static LottodoServices instance = null;
    private static final String prefixURL = "http://10.0.2.2:76/api/UserDetails/";

    //for Volley API
    public RequestQueue requestQueue;

    private LottodoServices(Context context)
    {
        requestQueue = Volley.newRequestQueue(context.getApplicationContext());
        //other stuf if you need
    }

    public static synchronized LottodoServices getInstance(Context context)
    {
        if (null == instance)
            instance = new LottodoServices(context);
        return instance;
    }

    //this is so you don't need to pass context each time
    public static synchronized LottodoServices getInstance()
    {
        if (null == instance)
        {
            throw new IllegalStateException(LottodoServices.class.getSimpleName() +
                    " is not initialized, call getInstance(...) first");
        }
        return instance;
    }

    public void CreateAccount(Object param1, final LottodoCustomListener<String> listener)
    {

        String url = prefixURL + "CreateAccount";

        Map<String, Object> jsonParams = new HashMap<String, Object>();
        jsonParams.put("ltd_tbl_userdetails", param1);

        JsonObjectRequest request = new JsonObjectRequest(Request.Method.POST, url, new JSONObject(jsonParams),
                new Response.Listener<JSONObject>()
                {
                    @Override
                    public void onResponse(JSONObject response)
                    {
                        Log.d(TAG + ": ", "Create Account Response : " + response.toString());
                        if(null != response)
                            listener.getResult(response.toString());
                    }
                },
                new Response.ErrorListener()
                {
                    @Override
                    public void onErrorResponse(VolleyError error)
                    {
                        if (null != error.networkResponse)
                        {
                            Log.d(TAG + ": ", "Error Response code: " + error.networkResponse.statusCode);
                            listener.getResult("Error"+" : "+error.getMessage());
                        }
                    }
                });

        requestQueue.add(request);
    }
}

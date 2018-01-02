package master.hci.beamer;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.location.LocationManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ImageView;
import android.widget.TextView;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class MainActivity extends AppCompatActivity {

    //socket server port on which it will listen
    private static int port = 9876;
    private ImageView iv;
    private java.net.ServerSocket serverSocket;
    private String nachricht;
    private Bitmap Nav;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Nav = BitmapFactory.decodeResource(getResources(), R.drawable.clear);
    }
    @Override
    protected void onStart() {
        super.onStart();
        try {
            iv = (ImageView)findViewById(R.id.main);
            serverSocket = new java.net.ServerSocket(port);
        } catch(Exception e){}
            Runnable myRunnable = new Runnable() {
                @Override
                public void run() {
                    while (true) {
                        try {
                            Thread.sleep(1000); 
                            java.net.Socket client = warteAufAnmeldung(serverSocket);
                            nachricht = leseNachricht(client);
                            client.close();
                        } catch (Exception e) {
                            //do some magic exception-handling
                        }

                        /******************************************************************/
                        // GERADEAUS
                        /*****************************************************************/
                        if (nachricht.equals("a_0")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_0);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_1")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_1);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_2")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_2);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_3")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_3);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_4")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_4);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }

                        /******************************************************************/
                        // HALB-LINKS
                        /*****************************************************************/
                        if (nachricht.equals("a_hl_0")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_hl_0);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_hl_1")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_hl_1);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_hl_2")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_hl_2);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_hl_3")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_hl_3);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_hl_4")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_hl_4);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }

                        /******************************************************************/
                        // HALB-RECHTS
                        /*****************************************************************/
                        if (nachricht.equals("a_hr_0")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_hr_0);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_hr_1")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_hr_1);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_hr_2")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_hr_2);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_hr_3")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_hr_3);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_hr_4")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_hr_4);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }

                        /******************************************************************/
                        // LINKS
                        /*****************************************************************/
                        if (nachricht.equals("a_l_0")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_l_0);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_l_1")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_l_1);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_l_2")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_l_2);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_l_3")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_l_3);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_l_4")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_l_4);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }

                        /******************************************************************/
                        // RECHTS
                        /*****************************************************************/
                        if (nachricht.equals("a_r_0")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_r_0);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_r_1")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_r_1);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_r_2")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_r_2);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_r_3")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_r_3);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("a_r_4")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.a_r_4);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }

                        /******************************************************************/
                        // SONSTIGES
                        /*****************************************************************/
                        if (nachricht.equals("dreieck")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.dreieck);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("goal")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.goal);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("kreis")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.kreis);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("quadrat")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.quadrat);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("start")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.start);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }
                        if (nachricht.equals("clear")) {
                            iv.post(new Runnable() {
                                @Override
                                public void run() {
                                    Nav.recycle();
                                    Nav = BitmapFactory.decodeResource(getResources(), R.drawable.clear);
                                    Nav = Bitmap.createScaledBitmap(Nav, iv.getWidth(), iv.getHeight(), true);
                                    iv.setImageBitmap(Nav);}});
                        }


                    }


                }

            };
        Thread myThread = new Thread(myRunnable);
        myThread.start();

    }

    Socket warteAufAnmeldung(ServerSocket serverSocket) throws IOException {
        java.net.Socket socket = serverSocket.accept(); // blockiert, bis sich ein Client angemeldet hat
        return socket;
    }

    String leseNachricht(java.net.Socket socket) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(socket.getInputStream()));
        char[] buffer = new char[200];
        int anzahlZeichen = bufferedReader.read(buffer, 0, 200); // blockiert bis Nachricht empfangen
        String nachricht = new String(buffer, 0, anzahlZeichen);
        return nachricht;
    }

    void schreibeNachricht(java.net.Socket socket, String nachricht) throws IOException {
        PrintWriter printWriter = new PrintWriter(new OutputStreamWriter(socket.getOutputStream()));
        printWriter.print(nachricht);
        printWriter.flush();
    }
}

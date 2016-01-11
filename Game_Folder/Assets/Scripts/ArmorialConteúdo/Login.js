/*private var secretKey=""; // Edit this value and make sure it's the same as the one stored on the server

 

var skin:GUISkin;

 

//var createuserUrl="http://mandown.unity3dgallery.com/cuser.php";

var getuserUrl="localhost/Unity/getuser.php";

//var feedURL="http://mandown.unity3dgallery.com/feed.txt";

var usernameText="";

var passwordText="";

var userOK=false;

var console="";

var email = "";

var born = "";

var nick = "";

var feed = "";

var i = 0;

var user = "";

var adminCP = false;

private var register = false;

//function createUser(username, password, email, born, nick) {
//
//    //This connects to a server side php script that will add the name and score to a MySQL DB.
//
//    // Supply it with a string representing the players name and the players score.
//
//    var hash = md5.Md5Sum(username + password + email + born + nick + secretKey);
//
// 
//
//    var createuser_url = createuserUrl + "username=" + WWW.EscapeURL(username) + "&password=" + WWW.EscapeURL(password) + WWW.EscapeURL(email) + WWW.EscapeURL(born) + WWW.EscapeURL(nick);
//
//       
//
//    // Post the URL to the site and create a download object to get the result.
//
//    var cu_post = WWW(createuser_url);
//
//    yield cu_post; // Wait until the download is done
//
//    if(cu_post.error) {
//
//        print("There was an error creating your user: " + cu_post.error);
//
//    }
//
//}

 

//var version : int = 1;
//
// 
//
//function CheckVersion()
//
//{
//
//    var update_url = "http://mandown.unity3dgallery.com/version.txt";
//
//    update_post = WWW(update_url);
//
//    yield update_post; // Wait until the download is done
//
//    if(update_post.error)
//
//    {
//
//        print("There was an error loading the update URL: " + update_post.error);
//
//    }
//
//    else
//
//    {
//
//        var latestVersion : int;
//
//        latestVersion = int.Parse(update_post.data);
//
//        if (latestVersion >= version + 1)
//
//        {
//
//            System.Diagnostics.Process.Start("open","http://mandown.unity3dgallery.com/game/lvgame.7z");
//
//        }
//
//    }
//
//}
//
// 
//
//var feedBool = false;
//
//var feed2 = "";
//
//var feedS = true;
//
// 
//
//function Update()
//
//{
//
//    if (adminCP == false)
//
//    {
//
//        adminFeed = feed2;
//
//    }
//
//    if (userOK == true)
//
//    {
//
//        if (feedS == true)
//
//        {
//
//            feedUpdate();
//
//            feedS = false;
//
//        }
//
//        if (i<100000)
//
//        {
//
//            i++;
//
//        }
//
//        else
//
//        {
//
//            feedUpdate();   
//
//            adminFeed = feed2;
//
//        }
//
//        
//
//        if (feedBool == true)
//
//        {
//
//            feed = "Latest News: " + feed2 + " | " + i + " |";
//
//        }
//
//    }
//
//}

 

//function feedUpdate()
//
//{
//
//    var feed_get = "http://mandown.unity3dgallery.com/admin.php?command=requestFeed";
//
//        feed_post = WWW(feed_get);
//
//        yield feed_post;
//
//        if(feed_post.error)
//
//        {
//
//            print("There was an error loading the feed: " + feed_post.error);
//
//            feed = "Could not connect to feed";
//
//            feedBool = false;
//
//            i = 0;
//
//        }
//
//        else
//
//        {
//
//           i = 0;
//
//           feedBool = true;
//
//           feed2 = feed_post.data;
//
//        }
//
//}

 

function BeginPage(width,height) {

    GUILayout.BeginArea(Rect((width),(height),width,height));

}

 

function EndPage() {

    GUILayout.EndArea();

}

 

var userToDelete = "";

var feedChange = "";

var adminDetect = false;

 

function detectIsAdmin()

{

    var createuser_url = "http://mandown.unity3dgallery.com/verify.php" + "?username=" + usernameText + "&password=" + md5.Md5Sum(passwordText);

    var cu_get = WWW(createuser_url);

    yield cu_get;

   

    if(cu_get.error) {

        print("There was an error checking admin: " + cu_get.error);

    }

    else

    {

        if(cu_get.data == "yes")

        {

           adminDetect = true;

        }

       else

       {

          adminDetect = false;

       }

    }

}

 

var adminTest = false;

 

var toolbarInt = 0;

var toolbarStrings : String[] = ["Main Menu","Offline Maps", "Servers", "Forum", "Stats", "Map Creator"];

var adminFeed = "";

 

 

function OnGUI()

{

    GUI.matrix = Matrix4x4.TRS (Vector3.zero, Quaternion.identity, Vector3 (Screen.width / 600.0, Screen.height / 400.0, 1)); 

    if (skin != null) {

        GUI.skin = skin;

    }

    

   if (register == false && userOK == false)

   {

    GUI.Box(Rect (125,50,400,300), "Login");

    BeginPage(150,100);

        GUI.Label(Rect (30,20,60,20), "Username:");

        GUI.Label(Rect (30,47,60,20), "Password:");

        EndPage();  

        usernameText = GUI.TextField(Rect (250,117,150,20), usernameText, 25);

        passwordField.x = 250;

        passwordField.y = 145;

        passwordField.w = 150;

        passwordField.h = 20;

        passwordField.l = 25;

        passwordText = passwordField.PasswordField(passwordText, "*");

        if (GUI.Button(Rect (300,220,100,20), "Login") || Input.GetKeyDown("return"))

          checkUser();

        if (GUI.Button(Rect (300,260,100,20), "register"))

        {

          register = true;

        }

   }

   

   if (register == false && userOK == true)

   {

        if (adminTest == false)

        {

            detectIsAdmin();

            adminTest = true;

        }

        GUI.Box(Rect (10,10,575,360), "Main Menu");

        if (adminCP == false)

        {

            GUI.Label(Rect (20,20,500,20), feed);

            toolbarInt = GUI.Toolbar (Rect (25, 40, 550, 50), toolbarInt, toolbarStrings);

            if (toolbarInt == 0)

            {

            }

            if (toolbarInt == 1)

            {

            }

            if (toolbarInt == 2)

            {

            }

            if (toolbarInt == 3)

            {

            }

            if (toolbarInt == 4)

            {

            }

            if (toolbarInt == 5)

            {

            }

            if (toolbarInt == 6)

            {

            }

            if (adminDetect == true && GUI.Button(Rect (425,325,150,20), "Admin Control Panel"))

            {

                adminFeedBool = false;

                adminCP = true;

            }

        }

        else if (adminCP == true)

        {

            adminFeed = GUI.TextField(Rect (25,25,200,25), adminFeed, 50);

            user = GUI.TextField(Rect (25,50,200,25), user, 50);

            GUI.Label(Rect (230,25,200,25), " Feed");

            GUI.Label(Rect (230,50,200,25), " User to delete");

            if (GUI.Button(Rect (250,325,150,20), "Apply Changes"))

            {

                Apply();    

            }

            if (GUI.Button(Rect (425,325,150,20), "Back"))

            {

                adminCP = false;

            }

        }

   }

   

   if (register == true && userOK == false)

   {

    GUI.Box(Rect (100,50,420,300), "Register");

        GUI.Label(Rect (150,80,60,20),"Username:");

        GUI.Label(Rect (150,110,60,20),"Password:");

        GUI.Label(Rect (150,140,60,20),"Email:");

        GUI.Label(Rect (110,170,120,20),"Born (YYYY-MM-DD):");

        GUI.Label(Rect (150,200,60,20),"Nickname:");

      usernameText = GUI.TextField(Rect (210,80,180,20),usernameText, 25);

      passwordField.x = 210;

      passwordField.y = 110;

      passwordField.w = 180;

      passwordField.h = 20;

      passwordField.l = 25;

      passwordText = passwordField.PasswordField(passwordText, "*");

      email = GUI.TextField(Rect (210,140,180,20),email, 25);

      born = GUI.TextField(Rect (230,170,180,20),born, 25);

      nick = GUI.TextField(Rect (210,200,180,20),nick, 25);

      if (GUI.Button(Rect (300,260,100,100), "Register"))

         registerUsername();

   }

   GUI.Label(Rect (150,300,150,50), console);

}

 

function Apply()

{

    var feed_url = "http://mandown.unity3dgallery.com/admin.php?command=feed&feed=" + adminFeed;

    var cu_get = WWW(feed_url);

    yield cu_get;

 

        if(cu_get.error) {

           print("There was an error applying changes: " + cu_get.error);

        }

        else

        {

           if(cu_get.data == "yes")

           {

               feedUpdate();

           }

       else

     {

          print("error could not change!");

      }

    }

    

    var delete_url = "http://mandown.unity3dgallery.com/admin.php?command=delete&user=" + user;

    var cud_get = WWW(delete_url);

    yield cud_get;

 

        if(cud_get.error) {

           print("There was an error applying changes: " + cud_get.error);

        }

        else

        {

           if(cud_get.data == "yes")

           {

               feedUpdate();

           }

       else

     {

          print("error could not change!");

      }

    }

    adminCP = false;

}

 

function registerUsername()

{

    console = "registering you";

    var createuser_url = createuserUrl + "?username=" + usernameText + "&password=" + md5.Md5Sum(passwordText) + "&email=" + email + "&born=" + born + "&nick=" + nick;

    var cu_get = WWW(createuser_url);

    yield cu_get;

   

    if(cu_get.error) {

        console = "There was an error registering: " + cu_get.error;

    }

    else

    {

        if(cu_get.data == "registered")

        {

           console = "registered";

           yield WaitForSeconds(3.0);

           register = false;

        }

       else

       {

          console = "Error, please try again";   

       }

    }

}

 

function checkUser() {

    console = "Checking Username and Password";

    var getuser_url = getuserUrl + "?username=" + usernameText + "&password=" + md5.Md5Sum(passwordText);

    var cu_get = WWW(getuser_url);

    yield cu_get;

   

    if(cu_get.error) {

        console = "There was an error checking your username and password: " + cu_get.error;

    }

    else

    {

        if(cu_get.data == "right")

        {

           console = "Welcome back " + usernameText + " hope you enjoy the game!";

           yield WaitForSeconds(3.0);

           userOK=true;

        }

       else

       {

          userOK = false;

          console = cu_get.data;   

       }

    }

    

    CheckVersion();

}*/
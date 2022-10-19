//  mark ramirez
//  started 9/8/2022
//  mad lib story

Console.Clear();

int idk = 0;
bool validation = true;
bool playing = true;

while(playing == true)
{

Console.WriteLine("Would you like to make A story with me? I'll just have to ask you A few questions.");

string Fadjective = "";
validation = true;
while(validation == true){
Console.WriteLine("First I need An adjective.");
Fadjective = Console.ReadLine();

    bool NuM1 = Int32.TryParse(Fadjective, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}

string creature = "";
validation = true;
while(validation == true){
Console.WriteLine("Then I need any type of creature dosen't have to be human.");
creature = Console.ReadLine();

    bool NuM1 = Int32.TryParse(creature, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}

string Event = "";
validation = true;
while(validation == true){
Console.WriteLine("Now I need and event such as A holiday.");
Event = Console.ReadLine();

    bool NuM1 = Int32.TryParse(Event, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}

string Fverb = "";
validation = true;
while(validation == true){
Console.WriteLine("Ok A verb now that's in it's base form.");
Fverb = Console.ReadLine();

    bool NuM1 = Int32.TryParse(Fverb, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}

string Sadjective = "";
validation = true;
while(validation == true){
Console.WriteLine("An adjective.");
Sadjective = Console.ReadLine();

    bool NuM1 = Int32.TryParse(Sadjective, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}

string gender = "";
validation = true;
while(validation == true){
Console.WriteLine("he/she/they.");
gender = Console.ReadLine();

    bool NuM1 = Int32.TryParse(gender, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}

string Fnoun = "";
validation = true;
while(validation == true){
Console.WriteLine("A noun.");
Fnoun = Console.ReadLine();

    bool NuM1 = Int32.TryParse(Fnoun, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}

string Sverb = "";
validation = true;
while(validation == true){
Console.WriteLine("Another verb that end with An s.");
Sverb = Console.ReadLine();

    bool NuM1 = Int32.TryParse(Sverb, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}

string Tadjective = "";
validation = true;
while(validation == true){
Console.WriteLine("Second to last adjective.");
Tadjective = Console.ReadLine();

    bool NuM1 = Int32.TryParse(Tadjective, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}

string Snoun = "";
validation = true;
while(validation == true){
Console.WriteLine("What about A noun.");
Snoun = Console.ReadLine();

    bool NuM1 = Int32.TryParse(Snoun, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}

string Ladjective = "";
validation = true;
while(validation == true){
Console.WriteLine("Ok now this is the last adjective this one needs to end with ness.");
Ladjective = Console.ReadLine();

    bool NuM1 = Int32.TryParse(Ladjective, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}

string edverb = "";
validation = true;
while(validation == true){
Console.WriteLine("Now I need A verb that end's with ed.");
edverb = Console.ReadLine();

    bool NuM1 = Int32.TryParse(edverb, out idk);
    if(NuM1 == false ){
        validation = false;
    }else if(NuM1 == true){
    }
}

Console.WriteLine("Ok now I need A building.");
string building = Console.ReadLine();
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine($"The {Fadjective} {creature}");
Console.WriteLine($"felt sad so {gender} decided they were going to set up {Event}");
Console.WriteLine($"after {gender} {Fverb} the {Sadjective} {Fnoun}");
Console.WriteLine($"filled with {Sverb} {gender} then decided to invite all the");
Console.WriteLine($"{Tadjective} {Snoun} to the building");

bool yessir = true;
Console.WriteLine("want to play again");
string responce = Console.ReadLine();
while(yessir == true)
{
responce.ToLower();
if(responce == "yes" ){
yessir = false;
playing = true;
}else if(responce == "no" ){
yessir = false;
playing = false;
}else{
Console.WriteLine($"so like i need a yes or no not this \"{responce}\" ");
responce = Console.ReadLine();
}
}
}
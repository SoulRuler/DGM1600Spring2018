using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {

public int a;
public int b;
public string password;

	void start()
	{

print("are you ready for this");
print("bum dum bum bum bum bum dum bum bum bum bum dum dum bum bu mbu mbum bu bmdubmbum");

	}

	void OnMouseDown()
	{
		
		if(a < b)
		{
			print("a is less then b");
		}

		if(a == b)
		{
			print("a is equal to b");
		}

		if(a > b)
		{
			print("a is greater then b");
		}
		
		if(a != b && password != "wootwoot")
		{
			print("you dun messed up");
		}

		if(a == b && password == "wootwoot")
		{
			print("wootwoot you did it");
		}
	}

}


//We started off by talking about different opperators

//&& means also

//|| means or

//we talked about if a == b or a < b so on so forth

//we partied becuase we were bored

//a lot of if statments with passwords and logic stuff 

//there are more operators to talk about

//we were introduced to a scriptable object "power up"

//the anology was mad about chettahs and elephants

# Axceligent (PreTest)
  <p><i>A Simple test to Qualify the candidature.</i></p>

## Features ✨
* Sum of Biggest Neighbor.
* Implement the User class.
* John the Robot.
* Alexa Settings.
* Method Signature.
* Construction Game.
* ES6 Import
* Typescript Mastery



### Sum of Biggest Neighbor
```cs
public int Challenge(int[] input)
{
	//Groupby Order by Count Desc
	var grpBy = input.GroupBy(v => v).OrderByDescending(x => x.Count());
	//Find M 
	var M = grpBy.FirstOrDefault();
	//Removing the elements from the array which is repeated less than M-1 
	foreach (var gb in grpBy)
		if (gb.Count() < (M.Count() - 1))
			input = input.Where(x => x != gb.Key).ToArray();
	//Finding the Sum of Biggest Neighbor 
	int BigNeighbor = 0;
	for (int i = 0; i < input.Length - 1; i++)
	{
		if (BigNeighbor < input[i] + input[i + 1])
			BigNeighbor = input[i] + input[i + 1];
	}
	Console.WriteLine("Yes, The Solution Complexity is O(n)");
	return BigNeighbor;
}
```

### Implement the User class.
```cs
public class User
{
	public static List<string> UserList { get; set; } = new List<string>();
	public void Add(string userName)
	{
		UserList.Add(userName);
	}

	public int GetUsersCount()
	{
		return UserList.Count;
	}
}
```    
### John the Robot.    
```cs
public class Humanoid
{
	public string Skills { get; set; }
	public Humanoid()
	{
		Skills = "no skill is defined";
	}
	public Humanoid(Dancing dancing)
	{
		dancing = new Dancing();
		Skills = dancing.DancingSkill;
	}
	public Humanoid(Cooking cooking)
	{
		cooking = new Cooking();
		Skills = cooking.CookingSkill;
	}
	public string ShowSkill()
	{
		return Skills;
	}
}
public class Dancing : Humanoid
{
	public string DancingSkill { get; set; }
	public Dancing()
	{
		DancingSkill = "dancing";
	}
}
public class Cooking : Humanoid
{
	public string CookingSkill { get; set; }
	public Cooking()
	{
		CookingSkill = "cooking";
	}
}   
```    
### Alexa Settings.

```cs
public class Alexa
{
	public AlexaConfiguration ac { get; set; } = new AlexaConfiguration();
	public string TalkingString { get; set; }

	public Alexa()
	{
		TalkingString = "hello, i am Alexa";
	}
	public string Talk()
	{
		return TalkingString;
	}
	public void Configure(Action<AlexaConfiguration> config)
	{
		config(ac);
		TalkingString = ac.GreetingMessage.Replace("{OwnerName}", ac.OwnerName);
	}
}

public class AlexaConfiguration
{
	public string OwnerName { get; set; }
	public string GreetingMessage { get; set; }
}   
```    
### Method Signature.
```cs
Task<object> SomeCalculation(long x, int y, long z)
{
	return Task.FromResult<object>(null);
}
```

### Construction Game.
```cs
public class Building : List<Room>
{
	public static List<Room> RoomsList { get; set; } = new List<Room>();
	public Building rooms { get; set; } 
	public Building AddKitchen()
	{
		rooms = new Building();
		rooms.Add(new Room("kitchen"));
		RoomsList.Add(new Room("kitchen"));
		return rooms;
	}
	public Building AddBedroom(string BedroomType)
	{
		rooms = new Building();
		rooms.Add(new Room(BedroomType));
		RoomsList.Add(new Room(BedroomType));
		return rooms;
	}
	public Building AddBalcony()
	{
		rooms = new Building();
		rooms.Add(new Room("balcony"));
		RoomsList.Add(new Room("balcony"));
		return rooms;
	}
	public BuiltProperty Build()
	{
		BuiltProperty bp = new BuiltProperty();
		string Desc = string.Empty;
		foreach(Room rm in RoomsList)
		{
			Desc += rm.RoomName + ", ";
		}
		bp.Description = Desc;
		return bp;
	}
}
public class Room
{
	public string RoomName { get; set; }
	public Room(string roomName)
	{
		RoomName = roomName;
	}
}
public class BuiltProperty
{
	public string Description { get; set; }
	public string Describe()
	{
		return Description;
	}
}
```
### ES6 Import

	Type 1:  1, 5
    
	Type 2:  2, 4

### Typescript Mastery
```ts
function subtract(subnum: number){
 return function (target: any, propertyKey: string, descriptor: PropertyDescriptor) {
   let originalValue = descriptor.value;
   descriptor.value = function (...args: any[]) {
     let result = originalValue.apply(this, args) - subnum;
     return result;
   }
   return descriptor;
 };
}
function multiply(mulnum: number){
 return function (target: any, propertyKey: string, descriptor: PropertyDescriptor) {
   let originalValue = descriptor.value;
   descriptor.value = function (...args: any[]) {
     let result = originalValue.apply(this, args) * mulnum;
     return result;
   }
   return descriptor;
 };
}
class MathClass {
 @subtract(1)
 @multiply(2)
 addOne(number: number) {
   return number + 1 ;
 }
}
console.log(new MathClass().addOne(2)) //Will print 5
```

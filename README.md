# in-class-activities
## Devlogs
### W1
Hello world!
When the camera is moved off of the Cat GameObject, the camera stays in place and does not follow the cat like it did previously. This happens because the camera is no longer a child of the Cat and the movement is no longer tied to it.

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

1: The r, g, and b variables are all floats instead of integers, booleans, or strings because a float is for decimals and rgb values are decimal values, the other types would not be able to store it correctly.
2: The _bounce variable is an integer instead of a float, boolean, or string because it is meant to count whole numbers of bounces. This is fit for the integer type.
3: The error told me that a semicolon was missing.

### W3

Table 16
The parameter is int sanity. The output is void.

Metaphor: Batman is the class. He can enter the batmobile to control its functions as a component. Batman has gadgets that are the member variables and can use those gadgets in methods that are his actions.
There is no limit for the brightness, so the multiplier can keep making the balls brighter and brighter.

### W4
Table 16
Line 17: Creates a private boolean member variable set to true called '_isGrounded' 
Line 28: Uses an if statement to check if the space key is pressed down and the _isGrounded variable is true.
Line 32: Sets the _isGrounded variable to false.

We added Rigidbodies to the cat and soccer ball, with the IsTrigger checked on the goal.
I forgot to make the time updating code += instead of just =, so the time since last goal was resetting constantly.

### W5

Question: How do you use the getComponent function/ what is the proper syntax when using it.
Answer: It gets the component from a gameObject as a reference. You can set it to a variable or directly use a method on it. When not setting it to a vaariable you can add the method to the end, like ___.getComponent<>().StopAnimation()
Plan:
Create a player gameObject. Get the player transform from that object. Get the navmesh agent from the deer and use setDestination to make the deer follow the deer transform position.
Member Variables: _catTransform to get the transform of the cat, _cat to get the cat gameObject.
Methods: It should use the Update() method to set _catTransform to the transform component, then use GetComponent to get the navmeshagent and set the destination to the _catTransform's position. 

### W6
My category: C# Scripting
[Google Doc:](https://docs.google.com/document/d/1_FuPSWqTkXPrMthJ3fE3VoS7TKVECOjqZArYk2FPLWk/edit?usp=sharing)
BatW6
monobehaviour, 
Member variables: [SerializeField} float _speed, catPosition, batPosition, cat reference
Start chasing: 
enabled = true
Stop chasing: 
enabled = false
update:
get player position, get bat position.
Use MoveTo

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 

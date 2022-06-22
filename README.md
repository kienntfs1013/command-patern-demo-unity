# command-patern-demo-unity
<h2>Introduction</h2>

<div>
In object-oriented programming, the command pattern is a behavioral design pattern in which an object is used to encapsulate all information needed to perform an action or trigger an event at a later time. This information includes the method name, the object that owns the method and values for the method parameters.
</div>
 
<h2>Description</h2>

<div>
- The problem is, we will perform the character's actions every time we press any key, assuming we press key A, the MoveA() method will be called, and the box will move. However, the problem continues to ask that, the player can change the button to perform a move action instead of the A button on the keyboard, for example, press the key D. At this point we cannot Pure code as above, we will need to use the Command pattern to make it easy for the User to change what they want to change
</div>
  
<div>
- Step 1: Define Command.cs
</div>
  
<div>
- Step 2: Inherit class Command to define class MoveRight and class DoNothing
</div>
    
<div>
- Note: The reason we created the DoNothing class is to cancel the function of a previously assigned key
</div>
      
<div>
- Step 3: Declare and use MoveRight, DoNothing
</div>
        
<div>
- Finally, we just need to write the Input handler function in the Update function of the InputHandler.cs
</div>

# SimpleCalc
Simple calculator I built in C#.  Built with .NET 5.  This Project is now my final project for SD 1 / Code Louisville.  

This is just as the name says, it is a Simple Calculator.  It will only at this moment will do simple arithmatic.  (add, subtract, multiply, devide) It will only take two numbers at the moment.  

I have 

It will ask you for the the first number, and then the second number and ask how you would like to process the numbers. 1.Add, 2.Subtract, 3.Multiply, 4.devide.

It will then process the number and print out the solution.  

##The 3 Extra Features that I am using are:

###Master Loop : Line 17
I am looping the program is the user would like to keep using the program.

###Implement a regular expression : CheckExpressions.CS (I have them all isolated)
I am using regular expressions Only in the CheckExpressions.CS to limit how much I am repeating code in the program.  

####IsInputANumber Method:
I have it Checking for Any size decimal string for the 2 numbers that the user may enter in.

####CheckOperatorInput Method:
Is checking that only the numbers 1-4 are used and only 1 digit long.

####CheckYesOrNo Method:
Is checking that only the 4 diffrent options for yes and no are able to use continue.

###Create an additional class which inherits one or more properties from its parent
I have CheckExpression as the parrent and I have IntroCheck and Equations as its child to pull the Check Expression info.


##


## Things to work on:
```
Work on adding Checks for numbers after they have been entered.
Work on breaking in Methods and Classes if able to.
```

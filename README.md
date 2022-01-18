# Piggy Bank
Save your money with this WFA.

**PiggyBank** is a saving money app. 
By using this application, you can store and manage the information of teams, players and matches between teams for real sports teams or sports activities among your friends.

**WeAreTheChampions** is designed with C# language and Windows Form App .Net Framework. It used MS-SQL in database and used Entity Framework CodeFirst approach.

## Usage Scenario

- It will hold coins and banknotes in the piggy bank.

- Each coin has its own value and volume.

- The piggy bank has a certain volume. The amount of money that can be thrown in is limited. Each tossed coin will increase the volume of the piggy bank. A new coin must not be inserted into an overfilled piggy bank.

- Coins do not settle properly when tossed. Therefore, when the Shake() method works, the volumes occupied by the coins in the piggy bank come to their minimum values.

- Each banknote is foldable. It is not possible to throw paper money into the piggy bank without folding it.

- Moneys can only be displayed when the Break() method is called.

- The piggy bank will be glued for once. In other words, once broken and the amount displayed, the piggy bank can be glued and used again. However, once it is broken for the second time, it cannot be pasted again. (When the broken piggy bank is pasted, its balance will decrease to 0.)

![PublicUI](https://github.com/karatasarzu/WeAreTheChampions/blob/master/WeAreTheChampions/Resources/WATC.gif)

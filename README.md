# Piggy Bank
> Save your money with this WFA.

**PiggyBank** is designed with C# language and Windows Form App.
By using this application, you can enter the money you want to save, and when you want to break the piggy bank, you can view the money you have saved and the total amount.

## Usage Scenario

- It will hold coins and banknotes in the piggy bank.

- Each coin has its own value and volume.

- The piggy bank has a certain volume. The amount of money that can be thrown in is limited. Each tossed coin will increase the volume of the piggy bank. A new coin must not be inserted into an overfilled piggy bank.

- Coins do not settle properly when tossed. Therefore, when the Shake() method works, the volumes occupied by the coins in the piggy bank come to their minimum values.

- Each banknote is foldable. It is not possible to throw paper money into the piggy bank without folding it.

- Moneys can only be displayed when the Break() method is called.

- The piggy bank will be glued for once. In other words, once broken and the amount displayed, the piggy bank can be glued and used again. However, once it is broken for the second time, it cannot be pasted again. (When the broken piggy bank is pasted, its balance will decrease to 0.)

![PublicUI](https://github.com/karatasarzu/PiggyBank/blob/master/PiggyBank/Resources/PiggyBank.gif)

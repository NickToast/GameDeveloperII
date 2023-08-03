//GAME DEVELOPER I
// Enemy Teemo = new Enemy("Teemo");

// Attack Blind = new Attack("Blinding Dart", 15);
// Attack Shroom = new Attack("Poison Shroom", 20);
// Attack Auto = new Attack("Auto Attack", 10);

// Teemo.AttackList.Add(Blind);
// Teemo.AttackList.Add(Shroom);
// Teemo.AttackList.Add(Auto);

// Teemo.RandomAttack();

//GAME DEVELOPER II
//Create instances of the Melee, Ranged, and Magic Caster classes
MeleeFighter Bruiser = new MeleeFighter("Bruiser");
RangedFighter Archer = new RangedFighter("Archer");
MagicCaster Wizard = new MagicCaster("Wizard");

//Perform the Kick Attack from your Melee class character on your Ranged character
Bruiser.PerformAttack(Archer, Bruiser.AttackList[1]);

//Perform the Rage method from your Melee class character on your Magic Caster character
Bruiser.Rage(Wizard);

//Perform the Shoot an Arrow Attack from your Ranged character on your Melee character (if you wrote everything as listed above, you should not have been able to attack due to the Distance constraint)
Archer.PerformAttack(Bruiser, Archer.AttackList[0]);

//Have your Ranged character perform the Dash method
Archer.Dash();

//Perform another Shoot an Arrow Attack from your Ranged character (this one should have worked now if everything is set up properly)
Archer.PerformAttack(Bruiser, Archer.AttackList[0]);

//Caster Actions
//Perform a Fireball Attack from your Magic Caster on your Melee character
Wizard.PerformAttack(Bruiser, Wizard.AttackList[0]);

//Have the Magic Caster perform the Heal method on the Ranged character
Wizard.Heal(Archer);

//Have the Magic Caster perform the Heal method on themselves
Wizard.Heal(Wizard);


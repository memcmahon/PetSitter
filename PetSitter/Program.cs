/*
 * Your mission is to build the scaffolding that will make the code below *compile* (it does not need to run).
 * You will be defining classes, and defining method signatures to match what is needed for the executable code below.
 * You do NOT need to complete all methods, you just need to implement enough of the method signature to remove the 
 * red squiggles :)
 */

//Instantiate Sitting Service
using PetSitter;

var northDenverPetSitters = new SittingService("North Denver Pet Sitters");

//Instantiate Sitters
var emily = new Sitter("Emily");
var kyle = new Sitter("Kyle");
var tyler = new Sitter("Tyler");

//Add sitters to the sitting service
northDenverPetSitters.AddSitter(emily);
northDenverPetSitters.AddSitter(kyle);
northDenverPetSitters.AddSitter(tyler);

//Instantiate Dogs
var nile = new Dog("Nile", "Mix");
var sammy = new Dog("Sammy", "Wirehaired Pointing Griffon");
var cutty = new Dog("Cutty", "Wirehaired Pointing Griffon");
var otto = new Dog("Otto", "Wiemeraner");
var penny = new Dog("Penny", "Vizla");
var lucy = new Dog("Lucy", "Mix");
var karl = new Dog("Karl", "Labrador");

//Add dogs to sitting service (this method would then assign each dog to a sitter)
northDenverPetSitters.AddDog(nile);
northDenverPetSitters.AddDog(sammy);
northDenverPetSitters.AddDog(cutty);
northDenverPetSitters.AddDog(otto);
northDenverPetSitters.AddDog(penny);
northDenverPetSitters.AddDog(lucy);
northDenverPetSitters.AddDog(karl);

//List dogs for a single sitter
var emilysDogs = emily.Dogs; //this would output a list of Dogs: nile, sammy, cutty, otto and penny.
var kylesDogs = kyle.Dogs; //this list of Dogs would be: lucy, karl
var tylersDogs = tyler.Dogs; //this would output an empty list of Dogs

//List all dogs at the sitting service
var allDogs = northDenverPetSitters.Dogs; //this would output a list of all the dogs





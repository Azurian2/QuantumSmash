


var startingHealth : int = 100;                             // The amount of health the player starts the game with.
var currentHealth : int;                                    // The current health the player has.


private var isDead : boolean;                                                // Whether the player is dead.


function Awake ()
{

    // Set the initial health of the player.
    currentHealth = startingHealth;
}





public function TakeDamage (amount : int)
    {


        // Reduce the current health by the damage amount.
        currentHealth -= amount;

        // If the player has lost all it's health and the death flag hasn't been set yet...
        if(currentHealth <= 0 && !isDead)
        {
            // ... it should die.
            Death ();
        }
    }


    function Death ()
    {
        // Set the death flag so this function won't be called again.
        isDead = true;
    }
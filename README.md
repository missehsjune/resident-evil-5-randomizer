
# Resident Evil 5 Enemy Randomizer

This is a little personal project I set for myself, to see if I could randomize the enemy locations and positions of one of my favourite games. 

Look at the [release page](https://github.com/missehsjune/resident-evil-5-randomizer/releases) for download links.

# Usage

First, download the latest version from the [release page](https://github.com/missehsjune/resident-evil-5-randomizer/releases), as well as [ARCtool by FluffyQuack](https://www.fluffyquack.com/tools/ARCtool.rar).

(Optional/Recommended) Make a backup of the level files (s100.arc through s512.arc) if you want to be able to revert to vanilla enemy spawns, or to reset enemy variety.These files can be located within the game install at *\steamapps\common\Resident Evil 5\nativePC_MT\Image\Archive*.

Next, copy ARCtool.exe into the location of the level files. Launch the program and select the folder containing ARCtool.exe.

Lastly, select the randomization options, explained below, you want applied to your game, and click generate. 

For randomized co-op playthroughs, choosing the same options and using the same seed number should work (testing required), otherwise, have one player randomize their game, and then send the other player their level files.

# Randomization Options

**Seed Number**

Provide a number for the program to use as the basis for the randomization.

**Enemy Variety**

The randomizer can be set to make entire spawn groups only consist of one enemy (single enemy per spawn group), or to retain the original variety present in the file (match original game's variety). 

If a spawn group consisted of three enemies, the second option will randomize that spawn group to contain three different enemies.
*MATCH ORIGINAL GAME'S VARIETY REQUIRES FRESH FILES TO WORK. IF YOU HAVE RANDOMIZED THE FILES WITH THE FIRST OPTION, THE SECOND OPTION CANNOT ADD VARIETY BACK.*

**Levels to Randomize**

Some levels can be problematic when randomized, so the first option (only safe levels) ensures only files that shouldn't lead to softlocks will be randomized. 

The second option will expand to include levels that *can* cause problems depending on what enemy gets placed where, i.e. unkillable enemies replacing enemies holding key items.

**Enemy List to Use**

Certain enemies can be too much for the game to handle (Wesker, the Ndesu, the various Oroborous bosses), so *only safe enemies* will only randomize the enemy spawns to enemies that *should* be safe from causing problems.

*All enemies*, on the other hand, will include every enemy that doesn't outright crash the game. *If using All enemies, it can be a good idea to reload checkpoints if many enemies are alive in a previous section to minimize crashing problems.*




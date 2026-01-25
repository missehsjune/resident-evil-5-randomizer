


# Resident Evil 5 Enemy Randomizer

This is a little personal project I set for myself, to see if I could randomize the enemy locations and positions of one of my favourite games. 

Look at the [release page](https://github.com/missehsjune/resident-evil-5-randomizer/releases) for download links.

## Requirements

This program was made in .NET Framework 4.7.2 so [installing the .NET Framework 4.7.2 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472) should be sufficient.

**[I highly recommend installing the RE5 QOL Fixes and Maluc's patch as they help make RE5 playable on modern systems and offer a variety of helpful options](https://steamcommunity.com/sharedfiles/filedetails/?id=1533171339)**

## Usage

**[For a video tutorial of downloading and using the randomizer, watch this.](https://youtu.be/ZLdQ5eCsIsE)**

1. Download the latest version from the [release page](https://github.com/missehsjune/resident-evil-5-randomizer/releases), as well as [ARCtool by FluffyQuack](https://www.fluffyquack.com/tools/ARCtool.rar).

2. Make a backup of the level files (s100.arc-s804.arc). If you wish to randomize your game a second time, restore the levels back to normal by replacing the game files with the backup before randomizing, otherwise unintended behaviour can occur.

3. Copy ARCtool.exe into the location of the level files. Launch the program and select the folder containing ARCtool.exe.

4. select the randomization options, explained below, that you want applied to your game, and click generate. 

For randomized co-op playthroughs, choosing the same options and using the same seed number should work (testing required), otherwise, have one player randomize their game, and then send the other player their level files.

When randomizing, Windows may ask if you want to run Arctool.exe. Select "Do not ask again" and then click run so that the program will continue without asking every time it needs to use Arctool.exe again. It will ask many, many times otherwise.

## Randomization Options

**Seed Number**

Provide a number for the program to use as the basis for the randomization. Set to the same number as a co-op partner, and use the same settings listed below to ensure co-op playthrough go smoothly.

**Randomize Enemies**

Check this box to have enemy randomization occur. The randomization options below will change how the randomization occurs. Enemy variety, which levels will get randomized, and which enemies to use can all be chosen below.

**Enemy Variety**

*Single enemy per spawn group* will turn every spawn group in the game, regardless of it's original variety, to be a single enemy (5 regular majini will become 5 chainsaw majini, for example).

*Match original game's variety* will randomize spawn groups with two or more enemies into having the same number of new enemies (2 dogs and 2 birds may become 2 gatling gun majini and 2 crocodiles, for example).

*MATCH ORIGINAL GAME'S VARIETY REQUIRES FRESH FILES TO WORK. IF YOU HAVE RANDOMIZED THE FILES WITH THE FIRST OPTION, THE SECOND OPTION CANNOT ADD VARIETY BACK.*

**Levels to Randomize**

*Only safe levels* will skip randomizing certain levels that can cause problems, such as Jill replacing an enemy that drops a kill.

With version 2.0.0, *all non-guaranteed crash levels* should be safe to use, due to extra key items being placed wherever an enemy would drop that key item. The choice is still available in case users want to be 100% sure.

*Main game + DLC levels* randomize the same levels as the above option, but also the DLC levels. Lost in Nightmares is fully playable, but a grenade is needed to blow open a wall. Desperate Escape can be beaten, but it may be pretty tough. Softlocks may occur due to enemies dropping keys, might figure out a fix at some point.

**Enemy List to Use**

*Only safe enemies* will only randomize enemies that should never cause problems in to the game.

*All enemies*, on the other hand, will include every enemy that doesn't outright crash the game. Some checks are in place to minimize crashing, but crashes can still happen. *If using All enemies, it can be a good idea to reload checkpoints if many enemies are alive in a previous section to minimize crashing problems.*

**Randomize Items**

Check this box to have item randomization occur. By default, placed items will be replaced with a list of basic items, including healing items, ammo, guns, etc. 

Selecting checkboxes below this option will *add* additional items to the list, so select all of them for the largest pool of items.

**Include Key Items**  
Check this box to include items necessary to progress to be randomized in to levels. They usually will not be usable unless you get lucky and get say, the Guard's Key in Chapter 1-2 near the Chainsaw Majini fight.

**Include Treasures**  
Check this box to include any and all treasure items to be randomized in to levels. Gems, bugs, etc. will all take the place of items. There are MANY treasures, so money won't be a problem, but there will be less of other items.

**Include Unsafe Items**  
Check this box to include many items never meant to be acquirable in to levels. The player character's knives, Chris' gatling gun, Sheva's bow (both usable on the wrong character), as well as enemy weapons and more. Some items can cause unintended behaviour when picked up.

**Include DLC Items**  
This will randomize in DLC key items, weapons, etc.

**Keep 2-1 Lantern**  
Check this box to leave the lantern in the mines in place. With the filter over the game normally, it can be too dark in the mines to see, so this option lets players guarantee the lantern during that section.

**Keep starting case as weapons**  
For fresh save files, the starting case of weapons Reynard provides will still have random weapons if this is selected. Having a weapon on the player character in solo, or both characters in co-op is necessary to continue.


## Known Issues
Co-op between Gold edition copies and non-Gold edition copies is possible, but both games need to be as similar as possible, and no DLC content can be randomized in.

## Uninstall
To uninstall the program, delete *re5-randomizer-gui* and all files that come with it in the download.
To restore the game to normal, either overwrite the level's .arc files with a backed up copy of the files, or delete the files or the Archive folder and validate the game files in Steam.

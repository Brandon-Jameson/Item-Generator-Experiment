# Item-Generator-Experiment
A small experiment playing around with generating random composite objects.

Comprised of Materials, Rarities, and ItemTypes, I am hoping to build a scalable, performant, and -most importanlty- an easy-to-work-with tool for future use in other projects.

## The Implementation
* Create a generator that will update the UI to display the item's Rarity, Material, ItemType.
* Create actual objects that will represent these 3 unique, and interconnected aspects. ItemTypes will be swords and helmets, Materials will give bonuses or maluses, rarity will improve the final product and have those nice colours we all love in RPG's.
* Materials will be represented as concrete child classes which inherit from an ItemMaterial super class.
* ItemTypes will follow a very similar format.
* Rarity is implemented as a dictionary of hex values stored as strings, alongside their rarity. This is then parsed in RarityGenerator into a usable colour, which then changes the colour of the itemText to the relevant colour (Gold for legendary, green for uncommon, etc.).
* The generated object will eventually be a composite gameObject made up of a Rarity, ItemType, and ItemMaterial, and will contain the name of the object, it's rarity, material, damage/protection, weight, value, and any special effects.

## Materials
### Metals
Metals are Materials that, while heavy, offer extremely supreme protection, and are the only Material strong enough to endure as weaponry. Simple in purpose, they lack any real benefits, other than specializing in damage and armour

### Textiles
Textiles are Materials that act as "augmentors". They provide bonuses, mainly to resistances, stats, and apply other modifiers.

### Woods
Woods are Materials that excel at diffusing strong magics, and thus have an emphasis on elemental damage resistance, while remaining light. They are, however, quite low-valued, and are too brittle to make for good weaponry (maybe in the future with bows, or quarterstaff-type weaponItems).

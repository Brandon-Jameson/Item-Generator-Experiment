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
#### Copper:
  *   DamageRange: (453-1812)
  *   Protection: 1
  *   Weight: 0.8
  *   Value: 0.7
#### Iron:
  *   DamageRange: (453-2718)
  *   Protection: 2
  *   Weight: 1.3
  *   Value: 1
#### Steel:
  *   DamageRange: (906-3171)
  *   Protection: 3
  *   Weight: 1.2
  *   Value: 1.1
#### Gold:
  *   DamageRange: (906-4077)
  *   Protection: 4
  *   Weight: 2
  *   Value: 2
#### High Alloy:
  *   DamageRange: (906-4983)
  *   Protection: 6
  *   Weight: 0.9
  *   Value: 3
#### Valerium:
  *   DamageRange: (1359-5436)
  *   Protection: 14
  *   Weight: 1.4
  *   Value: 2.4
#### Pharium:
  *   DamageRange: (1359-6342)
  *   Protection: 8
  *   Weight: 0.3
  *   Value: 3
#### Maleverium:
  *   DamageRange: (1812-6795)
  *   Protection: 10
  *   Weight: 0.8
  *   Value: 5

### Textiles
Textiles are Materials that act as "augmentors". They provide bonuses, mainly to resistances, stats, and apply other modifiers.

### Woods
Woods are Materials that excel at diffusing strong magics, and thus have an emphasis on elemental damage resistance, while remaining light. They are, however, quite low-valued, and are too brittle to make for good weaponry (maybe in the future with bows, or quarterstaff-type weaponItems).

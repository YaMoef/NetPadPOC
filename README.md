# NetpadPOC

This is a small and simple POC that demonstrates some points I would like to see improved. The points are:
- Name of entity for navigation property where foreign key is named like `entityId` (in poc book -> author with `RandomPrimaryKey` as FK)
  - The navigation property is set in NetPad with the name `RandomPrimaryKeyNavigation` which I rather would like to be `Author`, which is the case when referencing the assembly
- Properties which are allcaps will be converted to pascal case (in poc book with prop `ISBN`, in NetPad it is named `Isbn`)
  - I would like to see this to still be `ISBN` in NetPad. This is the case when referencing the assembly
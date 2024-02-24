# NetpadPOC

This is a small and simple POC that demonstrates some points I would like to see improved. The points are:
- Name of entity for navigation property where foreign key is named like `entityId` (in poc book -> author with `RandomPrimaryKey` as FK)
  - The navigation property is set with the name `RandomPrimaryKeyNavigation` which I rather would like to be `Author`
- Properties which are allcaps will be converted to pascal case (in poc book with prop `ISBN`)
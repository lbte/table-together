# Domain Models

## Menu

```csharp
class Menu 
{
    Menu Create();
    void AddDinner(Dinner dinner);
    void RemoveDinner(Dinner dinner);
    void UpdateMenuSection(MenuSection section);
    
}
```

```json
{
    "id": "62e31cb6-1915-422e-b6cd-e5c1b1ed0e15",
    "name": "Nice menu",
    "description": "Menu with yummy food",
    "averageRating": 4.5,
    "sections": [
        {
            "id": "62e31cb6-1915-422e-b6cd-e5c1b1ed0e17",
            "name": "Appetizers",
            "description": "Starters",
            "items": [
                {
                    "id": "62e31cb6-1915-422e-b6cd-e5c1b1ed0e18",
                    "name": "Fried Pickles",
                    "description": "Deep fried pickles",
                    "price": 5.99
                }
            ]
        }
    ],
    "createdDateTime": "2025-01-01T00:00:00.0000000Z",
    "updatedDateTime": "2025-01-01T00:00:00.0000000Z",
    "hostId": "62e31cb6-1915-422e-b6cd-e5c1b1ed0e11",
    "dinnerIds": [
        "62e31cb6-1915-422e-b6cd-e5c1b1ed0e12",
        "62e31cb6-1915-422e-b6cd-e5c1b1ed0e13"
    ],
    "menuReviewIds": [
        "62e31cb6-1915-422e-b6cd-e5c1b1ed0e14",
        "62e31cb6-1915-422e-b6cd-e5c1b1ed0e16"
    ]
}
```
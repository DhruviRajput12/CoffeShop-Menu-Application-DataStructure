## Starbucks-Inspired Restaurant Mobile Application

This mobile application draws inspiration from the Starbucks mobile app and offers users a seamless experience for selecting items from various sub-menus, browsing the restaurant's catalog, adding items to the bag, and selecting different payment options. The application utilizes design patterns such as Abstract Factory, Factory, and Flyweight to ensure efficient functionality.

### Key Features

1. **Main Menu and Sub-Menus:**
   - Users can navigate through a menu of menus, enabling them to select from different sub-menus.
   - Each sub-menu contains a unique set of items, providing a diverse range of choices.

2. **Item Selection:**
   - Users can choose different items from the sub-menus according to their preferences.
   - The menu structure allows users to explore the entire restaurant's catalog by navigating back and forth between menus.

3. **Bag Management:**
   - Users have the option to add multiple items to their bag, allowing them to create and customize their order.
   - The bag total is dynamically updated based on the items added.

4. **Payment Options:**
   - The application offers various payment options, allowing users to choose their preferred method for completing the transaction.

### Design Patterns Used

1. **Abstract Factory Design Pattern:**
   - A menu of menus is created using the Abstract Factory design pattern.
   - Different sub-menus are accessed based on user input.

2. **Factory Design Pattern:**
   - Sub-menus utilize the Factory design pattern to provide various items to each sub-menu.
   - Based on user input, specific types of sub-menus and their corresponding items are retrieved.

3. **Flyweight Design Pattern:**
   - The Menu class implements the Flyweight design pattern to optimize memory usage.
   - By minimizing the number of item objects created, the application's performance is enhanced.

### Data Structures Used

- Five data structures are employed to manage different aspects of the application:
  - Bag Total: Keeps track of the total cost of items added to the bag.
  - Sub-menu Information: Four data structures, one for each sub-menu, store relevant item details.

### Usage

1. Launch the mobile application.
2. Navigate through the main menu and sub-menus to explore the variety of items.
3. Select items from the sub-menus and add them to your bag.
4. Review your bag's total cost and proceed to payment.
5. Choose your preferred payment option to complete the transaction.

### Note

- Ensure that the application provides a user-friendly and intuitive experience, focusing on the ease of navigation and item selection.
- Design patterns are used to enhance the application's architecture and performance, resulting in a smoother user experience.

### Conclusion

This Starbucks-inspired mobile application offers users a comprehensive and enjoyable experience when selecting items, managing their bag, and completing transactions. The implementation of various design patterns and data structures contributes to the efficiency and performance of the application, making it a user-friendly choice for restaurant enthusiasts.

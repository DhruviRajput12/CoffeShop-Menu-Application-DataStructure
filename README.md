### Starbucks-Menu-Application

## For this application, Took reference from the Starbucks Mobile Application. 
# The user Is able to do the following:

>> Select different Sub-Menus from the Main Menu
>> Choose different items from the Sub-Menus. 
>> Browse the whole catalogue of the restaurant by going back and forth in the menus.
>> Add multiple items to the bag.
>> Select various payment options.

First, a menu of menus has to be to be created which is why the use of Abstract Factory design pattern takes place. 


# A total of 5 Data Structures are used. 
-- One for the Bag Total while the remaining four holds the information of all the four sub-menus one for each.

# Main Menu:
-- The Main Menu takes input from the user about different sub-menu options. The design is achieved using the Façade Design Pattern. The GetOrder() method of the Order class is being called from the main class, both of which are using this design pattern so as to hide the complexiety of the application from the user. 

# Sub-Menu:
-- In the sub-menus, Factory Design Pattern is used so that different items can be provided to each sub-menu and based on the user input, the type of sub-menu and its items are retrieved. 

-- The Ifactory interface is implemented by the three sub-menus and all these sub-menu overrides the GetFactory() method to create their own description of the items.


# Information of Items:
-- The Menu class holds the implementation of various items’ information in which all of them implement the itemDescription interface. This interface contains the fields which are necessary for every item. 

-- The design pattern used here is FlyWeight so that the number of item objects created and the memory footprint can be decreased resulting in the performance of the application to increase.


My design was written through TDD. This provided me with the idea on how I wanted to create as little code
as possible whilst maintaining all of the functional expectations.

When starting out on the first widget, through TDD it was just that one shape needed.
However after the 2nd widget it became apparent that x and y were the most common so abstratcing them to a base class became useful
Then when looking at printing all of the objects, it would be useful to have that as a required method

If I had more time I would have looked into changing the print method to allow for printing to be easier done
As for now it is running in a for loop on the main program.
Preferable I would factor DDD into this and a cleaner architecture to keep the Console Printing from impacting the functionality / or business requirements

----
Other notes to factor.
I did look / think of creating a factory pattern to allow for creation of each object in the factory
This would have allowed me to create a slightly more standardised way.

But for now polymorphism was enough.

---

##User Management
###Goals of this topic
    - user managment was genrally contribution of my classmate Tom during project at GFA, thats why I would like to make everything on my own from zero to hero
    - how to hash password to DB
    - JWT authentication
    - verify email
    - different role of users
    Optinal:
    - customize chat for users to learn more about SignalR framework
    
###User managment requirments:
    - user should login
    - user have role
    - JWT token authentication
    - email verification of user
    - able to upload profile image
    - able to get his profile page
    - user password is hashed in DB
    - the user behaves according to the relevant role
    
###User Role Description
    ####admin 
    - only one admin in whole app
    - can do everything, because of admin 
    
    ####boss 
    - multiple bosses avaible
    - can fill the Outlet with incoming parts or material
    - can make new order
    - can create new technician (user in role Technician)
    - can create new inventory request
    
    ####technician
    - multible technician avaible
    - can take out material from outlet 
    - can NOT increase amount of part in outlet
    - the material that the technician has packed can be kept with him  in the warehouse
             

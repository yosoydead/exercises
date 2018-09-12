Create a simple program that validates user login credentials.
        The program must prompt the user for a username and
        password. The program should compare the password given
        by the user to a known password. If the password matches,
        the program should display “Welcome!” If it doesn’t match,
        the program should display “I don’t know you.”

Constraints
    • Use an if/else statement for this problem.
    • Make sure the program is case sensitive.

Challenges
    • Investigate how you can prevent the password from
    being displayed on the screen in clear text when typed.
    • Create a map of usernames and passwords and ensure
    the username and password combinations match. -> not needed for this specific problem. overkill
    • Encode the passwords using Bcrypt and store the
    hashes in the map instead of the clear-text passwords.
    Then, when you prompt for the password, encrypt the
    password using Bcrypt and compare it with the value
    in your map. -> not needed for this specific problem. overkill
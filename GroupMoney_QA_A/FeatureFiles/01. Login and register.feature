Feature: 01. Login and register


Scenario: T01_RegisterUser
#Pre-conditions
	Given Open the 'Home' page
	#Step 1
	When  Click 'Sign In' button on 'Home'
		And Set 'test_1@test.com' text value to 'Login' text input on 'Login'
		And Click 'Next' button on 'Login'
		And Set 'Johnny Depp' text value to 'Full name' text input on 'Login'
		And Set 'Password' text value to 'Password' text input on 'Login'
		And Click 'Sign In' button on 'Login'
		And Click 'Create New Group' button on 'Choose Group'
		And Set 'New group' text value to 'Group Name' text input on 'Choose Group'
		And Click 'Create New Group' button on 'Choose Group'
	Then The 'Main' page is opened
		And Text value of 'Username' label on 'Main' is 'test_1@test.com'


Scenario: T02_LoginNavigation
#Pre-conditions
	Given Open the 'Home' page
	#Step 1
	When Click 'Sign In' button on 'Home'
	Then The 'Login' page is opened
		And Text value of 'Action' label on 'Login' is 'Sign in with email'
	#Step 2
	When Set 'test_special@test.com' text value to 'Login' text input on 'Login'
		And Click 'Next' button on 'Login'
	Then The 'Login' page is opened
		And Text value of 'Action' label on 'Login' is 'Create account'
	#Step 3
	When Click 'Back' button on 'Login'
		And Set 'test02@test.com' text value to 'Login' text input on 'Login'
		And Click 'Next' button on 'Login'
	Then The 'Login' page is opened
		And Text value of 'Action' label on 'Login' is 'Sign in'


Scenario: T03_RegisterUserAndLogIn
#Pre-conditions
	Given Open the 'Home' page
	#Step 1
	When  Click 'Sign In' button on 'Home'
		And Set 'test003@test.com' text value to 'Login' text input on 'Login'
		And Click 'Next' button on 'Login'
		And Set 'Johnny Depp' text value to 'Full name' text input on 'Login'
		And Set 'Password' text value to 'Password' text input on 'Login'
		And Click 'Sign In' button on 'Login'
		And Click 'Create New Group' button on 'Choose Group'
		And Set 'New group' text value to 'Group Name' text input on 'Choose Group'
		And Click 'Create New Group' button on 'Choose Group'
	Then Text value of 'Username' label on 'Main' is 'test003@test.com'
	#Step 2
	When Click 'Sign Out' button on 'Main'
		And Click 'Sign In' button on 'Home'
		And Set 'test01@test.com' text value to 'Login' text input on 'Login'
		And Click 'Next' button on 'Login'
		And Set 'Password' text value to 'Password' text input on 'LogIn'
		And Click 'Sign In' button on 'LogIn'
	Then Text value of 'Username' label on 'Main' is 'T03_Username'
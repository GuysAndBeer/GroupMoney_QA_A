Feature: 02. Users and groups


Scenario: T01_NewUserData
#Pre-conditions
	Given Open the 'Register' page
	#Step 1
	When Set 'test01@test.com' text value to 'Login' text input on 'Login'
		And Click 'Next' button on 'Login'
		And Set 'Johnny Depp' text value to 'Full name' text input on 'Login'
		And Set 'Password' text value to 'Password' text input on 'Login'
		And Click 'Sign In' button on 'Login'
	Then Text value of 'Username' label on 'Main' is 'T01_Username'
		And Text value of 'Budget Money' label on 'Main' is '0$'
		And Text value of 'Budget Income' label on 'Main' is '0$'
		And Text value of 'Budget Debts' label on 'Main' is '0$'
	#Step 2
	When Click 'Members' button on 'Main'
	Then 'Members' grid contains 'Johnny Depp' text value


Scenario: T02_GroupsFunctionality
#Pre-conditions
	Given Open the 'Login' page
	#Step 1
	When Set 'test_2@test.com' text value to 'Login' text input on 'Login'
		And Click 'Next' button on 'Login'
		And Set 'Johnny Depp' text value to 'Full name' text input on 'Login'
		And Set 'Password' text value to 'Password' text input on 'Login'
		And Click 'Sign In' button on 'Login'
	Then The 'Choose Group' page is opened
	#Step 2
	When Click 'Create new group' button on 'Choose Group'
		And Set 'First group' text value to 'New Group Name' text input on 'Choose Group'
		And Click 'Members' button on 'Main'
		And Click 'Add Member' button on 'Main'
		And Set 'New user' text value to 'New User Name' text input on 'Main'
		And Click 'Save' button on 'Main'
	Then 'Members' grid contains 'Johnny Depp' text value
		And 'Members' grid contains 'New user' text value
	#Step 3
	When Click 'Choose Group' button on 'Main'
	Then The 'Choose Group' page is opened
	#Step 4
	When Click 'Create new group' button on 'Choose Group'
		And Set 'New group' text value to 'New Group Name' text input on 'Choose Group'
		And Click 'Save' button on 'Choose Group'
	Then 'Members' grid contains 'Johnny Depp' text value
		And 'Members' grid contains 'New user' text value
	#Step 5
	When Click 'Choose Group' button on 'Main'
		And Click button with 'Group1' text on 'Choose Group'
		And Click 'Members' button on 'Main'
		And Click 'Add Member' button on 'Main'
		And Set 'New user' text value to 'New User Name' text input on 'Main'
		And Click 'Save' button on 'Main'
	Then 'Members' grid contains 'Johnny Depp' text value
		And 'Members' grid contains 'New user' text value

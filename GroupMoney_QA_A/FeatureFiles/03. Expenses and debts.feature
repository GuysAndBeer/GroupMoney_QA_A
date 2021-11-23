Feature: 03. Expenses and debts


Scenario: T01_NewExpense
#Pre-conditions
	Given Open the 'Register' page
	#Step 1
	When Set 'test01_03@test.com' text value to 'Login' text input on 'Login'
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
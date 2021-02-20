Feature:Login
	Login to Skillswap

@mytag
Scenario: Perform Login 
	Given launch the application
	And Click on login button
	And Enter the following details
	     | Emailaddress                  |  Password  |
		 | lathishmasuvarnaa@gmail.com   | lathishma  |
    And    click on login button
	Then  should see the profile page
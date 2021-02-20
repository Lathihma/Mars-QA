Feature: Skills
	adding features to the Skills tab

@mytag
Scenario: successful Add to skill tab  
	  Given To enter the skill set form 
	  And  I click on add New button
	  And  I fill the details under the skill tab
	  When  you click on add button for skills
	              | skill |  level    |
	              | API   | Beginner  |
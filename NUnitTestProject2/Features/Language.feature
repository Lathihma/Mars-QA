Feature: Language
	Adding language details under language tab

@mytag
Scenario: successful save
	  Given To enter the languages set tab
	   And when you enter add feature for language
	  When you choose the option and click on add
	         | language  |     language level    |
	         | english   |     conversational    |
	  Then  the details will be saved










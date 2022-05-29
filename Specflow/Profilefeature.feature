Feature: Profilefeature

As a MARS QA Admin
I would like to add Language, Skills, Education and certification details and review it

@tag1
Scenario: [Add and review data in to the profile details]
	Given [I log in to the MAR QA website successfully]
	When [I want to add Language details]
	And [I want to add Skills details]
	And [I want to add Education details]
	And [I want to add Certification details]
	Then [The records should be created successfully]


Feature: Profilefeature

As a MARS QA Admin
I would like to add Language, Skills, Education and certification details and review it

@tag1
Scenario: [Add and review Language data into the profile details]
	Given [I log in to the MAR QA website successfully]
	When [I want to add Language details]
	Then [The records should be created successfully]

Scenario: [Add and review Skills data in to the profile details]
	Given [I log in to the MAR QA website for add skills]
	When [I want to add Skillls details]
	Then [The skills records should be created successfully]

Scenario: [Add and review Education data in to the profile details]
	Given [I log in to the MAR QA website to add education details]
	When [I want to add the Education details]
	Then [The education records should be created successfully]

Scenario: [Add and review Certification data in to the profile details]
	Given [I log in to the MAR QA website to add Certification details]
	When [I want to add the Certification details]
	Then [The Certification records should be created successfully]


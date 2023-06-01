Feature: BBCHomePage

As a user on BBC
I want to go on the homepage
so that I can read the news

@tag1
Scenario: Verify a user can view BBC homepage
	Given A user navigate to a website "https://www.bbc.co.uk/"
	When I click on login button 
	And I enter my username "borray24@hotmail.com"
	And I enter my password "Rayrayx2"
	And I click on sign in
	And I click on sounds on the header
	And I click on music
	And I click on Hip Hop, RnB & Dancehall
	And I click on Xtra's R&B Chill Mix
	#Then music start playing
	



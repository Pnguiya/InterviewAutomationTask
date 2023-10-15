Feature: Search

As an Amazon website user,I should be able to navigate
on the website ,selest items and add in the basket

Scenario: 01. verify that a user can add a Sport Watch in the basket
	Given that the amazon website is loaded on Chrome
	When a user fills in the search field with Sports Watch
	And a user clicks on search button
	And a user clicks on a smart watch
	And the user clicks on add to basket button
	Then the item should display Added to Basket


Scenario: 02. verify that a user can add a Camera Lens in the basket
    Given that the amazon website is loaded on Chrome
	When a user fills in the search field with Camera Lenses
	And a user clicks on search button
	And a user clicks on a camera lens
	And the user clicks on add to basket button
	Then the item should display Added to Basket


Scenario: 03. verify that a user can add a Laptop in the basket
    Given that the amazon website is loaded on Chrome
	When a user fills in the search field with Laptop
	And a user clicks on search button
	And a user clicks on a laptop
	And the user clicks on add to basket button
	Then the item should display Added to Basket

Feature:  Exposing basic automation information from controls

  Scenario: Wrapping basic automation information from controls
    When we are on the MainScreen
    Then we are able to expose the following basic information from controls:
      | property     | value             |
      | name         | Custom Panel Name |
      | id           | basicPanel        |
      | control_type | custom            |


pragma solidity ^0.4.2;

contract Private
{
    string helloString = "Hello";

    function callableFunction() public view returns (string) {
    return privateFunction();
    }

    function privateFunction() private view returns (string) {
        return helloString;
    }

}
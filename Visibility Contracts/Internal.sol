pragma solidity ^0.4.2;

contract Internal
{
    string helloString = "Hello";

    function callableFunction() public view returns (string) {
    return internalFunction();
    }

    function internalFunction() internal view returns (string) {
        return helloString;
    }

}
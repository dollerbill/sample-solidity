pragma solidity ^0.4.2;

contract External
{
    string helloString = "Hello";

    function externalFunction() external returns (string) {
        return helloString;
    }

}
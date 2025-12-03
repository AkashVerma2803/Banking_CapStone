pipeline {
    agent any

    environment {
        // This must match your Solution file name exactly
        SOLUTION_NAME = 'Banking_CapStone.sln' 
    }

    stages {
        stage('Checkout') {
            steps {
                // Gets code from GitHub
                checkout scm
            }
        }

        stage('Restore') {
            steps {
                echo 'Restoring Dependencies...'
                // Downloads the NuGet packages needed for your banking app
                bat "dotnet restore ${SOLUTION_NAME}"
            }
        }

        stage('Build') {
            steps {
                echo 'Compiling the Project...'
                // Compiles the C# code into an executable
                bat "dotnet build ${SOLUTION_NAME} --configuration Release --no-restore"
            }
        }

        stage('Test') {
            steps {
                echo 'Running Tests...'
                // Runs unit tests if you have them. 
                // If this fails because you have no tests, put // in front of the next line
                bat "dotnet test ${SOLUTION_NAME} --no-build"
            }
        }
    }
}
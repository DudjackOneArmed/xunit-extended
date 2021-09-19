﻿using System;
using Xunit.Assertation.Extensions.Exceptions;

namespace Xunit.Assertation.Extensions.Test
{
    public class AssertThatActionTest
    {
        [Fact]
        public void DoesNotThrow_ActionDoesNotThrowException_DoesNotThrowException()
        {
            // Arrange
            AssertThatAction assertThatAction = new(() => new object());

            // Act
            var exception = Record.Exception(() => assertThatAction.DoesNotThrow());

            // Assert
            Xunit.Assert.Null(exception);
        }

        [Fact]
        public void DoesNotThrow_ActionThrowsException_ThrowsDoesNotThrowAssertationException()
        {
            // Arrange
            AssertThatAction assertThatAction = new(() => throw new Exception());

            // Act & Assert
            Xunit.Assert.Throws<DoesNotThrowAssertationException>(() => assertThatAction.DoesNotThrow());
        }
    }
}

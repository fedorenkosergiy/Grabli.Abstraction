using JetBrains.Annotations;
using NUnit.Framework;
using System;

namespace Grabli.Abstraction.Tests
{
    /// <summary>
    /// Contains methods that can be used to test if the interface was implemented correctly
    /// </summary>
    [PublicAPI]
    public static class ListenableAssert
    {
        public static void CheckIfAddListenerReturnsTheSameIndexForTheSameListener<T>(
            [NotNull] Listenable<T> listenable,
            [NotNull] T listener)
        {
            int expected = listenable.AddListener(listener);
            int actual = listenable.AddListener(listener);
            Assert.AreEqual(expected, actual);
        }

        public static void CheckIfAddListenerThrowsArgumentNullExceptionWhenNull<T>([NotNull] Listenable<T> listenable)
            where T : class
        {
            Assert.Throws<ArgumentNullException>(() => listenable.AddListener(null!));
        }

        public static void CheckIfAddListenerReturnsDifferentIndexForDifferentListeners<T>(
            [NotNull] Listenable<T> listenable, [NotNull] T listener, [NotNull] T anotherListener)
        {
            Assert.AreNotSame(listener, anotherListener);
            int expected = listenable.AddListener(listener);
            int actual = listenable.AddListener(anotherListener);
            Assert.AreNotEqual(expected, actual);
        }

        public static void CheckIfRemoveListenerWasNotAddedReturnsFalse<T>([NotNull] Listenable<T> listenable,
            [NotNull] T listener)
        {
            Assert.IsFalse(listenable.RemoveListener(listener));
        }

        public static void CheckIfRemoveListenerWasAddedReturnTrue<T>([NotNull] Listenable<T> listenable,
            [NotNull] T listener)
        {
            listenable.AddListener(listener);
            Assert.IsTrue(listenable.RemoveListener(listener));
        }

        public static void CheckIfSecondCallRemoveListenerWasAddedReturnFalse<T>([NotNull] Listenable<T> listenable,
            [NotNull] T listener)
        {
            listenable.AddListener(listener);
            listenable.RemoveListener(listener);
            Assert.IsFalse(listenable.RemoveListener(listener));
        }

        public static void CheckIfRemoveListenerThrowsArgumentNullExceptionWhenNull<T>(
            [NotNull] Listenable<T> listenable)
            where T : class
        {
            Assert.Throws<ArgumentNullException>(() => listenable.RemoveListener(null!));
        }

        public static void CheckIfRemoveListenerByIndexReturnsTrue<T>([NotNull] Listenable<T> listenable,
            [NotNull] T listener)
        {
            int index = listenable.AddListener(listener);
            Assert.IsTrue(listenable.RemoveListener(index));
        }

        public static void CheckIfSecondCallRemoveListenerByIndexReturnsFalse<T>([NotNull] Listenable<T> listenable,
            [NotNull] T listener)
        {
            int index = listenable.AddListener(listener);
            listenable.RemoveListener(index);
            Assert.IsFalse(listenable.RemoveListener(index));
        }
    }
}
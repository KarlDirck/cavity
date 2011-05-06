﻿namespace Cavity.Collections.Generic
{
    using System;
    using System.Collections.Generic;

    public sealed class NormalizationComparer : INormalizationComparer
    {
        private static readonly NormalizationComparer _currentCulture = new NormalizationComparer(StringComparer.CurrentCulture);

        private static readonly NormalizationComparer _currentCultureIgnoreCase = new NormalizationComparer(StringComparer.CurrentCultureIgnoreCase);

        private static readonly NormalizationComparer _ordinal = new NormalizationComparer(StringComparer.Ordinal);

        private static readonly NormalizationComparer _ordinalIgnoreCase = new NormalizationComparer(StringComparer.OrdinalIgnoreCase);

        private IComparer<string> _comparer;

        public NormalizationComparer(IComparer<string> comparer)
            : this()
        {
            Comparer = comparer;
        }

        private NormalizationComparer()
        {
        }

        public static NormalizationComparer CurrentCulture
        {
            get
            {
                return _currentCulture;
            }
        }

        public static NormalizationComparer CurrentCultureIgnoreCase
        {
            get
            {
                return _currentCultureIgnoreCase;
            }
        }

        public static NormalizationComparer Ordinal
        {
            get
            {
                return _ordinal;
            }
        }

        public static NormalizationComparer OrdinalIgnoreCase
        {
            get
            {
                return _ordinalIgnoreCase;
            }
        }

        public IComparer<string> Comparer
        {
            get
            {
                return _comparer;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("value");
                }

                _comparer = value;
            }
        }

        int IComparer<string>.Compare(string x,
                                      string y)
        {
            return Comparer.Compare(x, y);
        }

        string INormalizationComparer.Normalize(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            return StringComparer.CurrentCultureIgnoreCase.Equals(Comparer) ||
                   StringComparer.InvariantCultureIgnoreCase.Equals(Comparer) ||
                   StringComparer.OrdinalIgnoreCase.Equals(Comparer)
                       ? value.ToUpperInvariant()
                       : value;
        }
    }
}
using System;
using System.Collections.Generic;
using MailChimp;
using MailChimp.Helper;
using MailChimp.Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimpTest
{
    [TestClass]
    public class MailChimpSpecs
    {
        private const string ApiKey = "595004ecb8704a2af38f4c68438ea9aa-us1";
        private const string ListID = "07e951ad75";
        private const string YahooMail = "bogdan_saca@yahoo.com";
        private const string GoogleMail = "bogdan.luca84@gmail.com";
        private const string HCMail = "bogdan@hotelscombined.com";

        [TestMethod]
        public void TestMethod1()
        {
            string oldEmail = HCMail;
            string newEmail = YahooMail;

            var mc = new MailChimpManager(ApiKey);
            var oldEmailParam = new EmailParameter { Email = oldEmail };
            var newEmailParam = new EmailParameter { Email = newEmail };
            var mergeVar = new MyMergeVar();
            mergeVar.NewEmail = "bogdan.luca@outlook.com";
            string bla = null;
            if (bla.EqualsIgnoreCase(null))
                bla = "bla bla";
            mc.Unsubscribe(ListID, oldEmailParam);
            mc.Subscribe(ListID, newEmailParam, mergeVar, doubleOptIn: false, updateExisting: true);
            //var updateMember = mc.UpdateMember(ListID, oldEmailParam, mergeVar);
            var oldMemberInfo = mc.GetMemberInfo(ListID, new List<EmailParameter> {oldEmailParam});
            var newMemberInfo = mc.GetMemberInfo(ListID, new List<EmailParameter> {newEmailParam});
        }
    }

    public static class StringExtender
    {
        public static bool EqualsIgnoreCase(this string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }
    }
}

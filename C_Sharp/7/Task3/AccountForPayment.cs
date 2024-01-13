using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Разработать класс «Счет для оплаты». В классе преду-
//смотреть следующие поля:
//■ оплата за день;
//■ количество дней;
//■ штраф за один день задержки оплаты;
//■ количество дней задержи оплаты;
//■ сумма к оплате без штрафа (вычисляемое поле);
//■ штраф(вычисляемое поле);
//■ общая сумма к оплате (вычисляемое поле).
//В классе объявить статическое свойство типа bool ,
//значение которого влияет на процесс форматирования
//объектов этого класса. Если значение этого свойства рав-
//но true , тогда сериализуются и десериализируются все
//поля, если false  — вычисляемые поля не сериализуются.
//Разработать приложение, в котором необходимо про-
//демонстрировать использование этого класса, результаты
//должны записываться и считываться из файла.

namespace Task_1
{
    class AccountForPayment
    {
        static Random rand = new Random();

        static bool serial = true;

        private int payPerDay;
        private int days;
        private int penaltyFor1DayDelayInPayment;
        private int daysToDelayPayment;

        private int amountPayableWithoutPenalty;
        private int fine;
        private int totalPayable;

        public AccountForPayment()
        {
            payPerDay = rand.Next(10, 100);
            days = rand.Next(2, 10);
            penaltyFor1DayDelayInPayment = rand.Next(2, 100);
            daysToDelayPayment = rand.Next(2, 10);
            amountPayableWithoutPenalty = payPerDay * days;
            fine = penaltyFor1DayDelayInPayment * daysToDelayPayment;
            totalPayable = amountPayableWithoutPenalty - fine;
        }
        public AccountForPayment(int PayPerDay, int Days, int PenaltyFor1DayDelayInPayment, int DaysToDelayPayment)
        {
            payPerDay = PayPerDay;
            days = Days;
            penaltyFor1DayDelayInPayment = PenaltyFor1DayDelayInPayment;
            daysToDelayPayment = DaysToDelayPayment;
            amountPayableWithoutPenalty = payPerDay * days;
            fine = penaltyFor1DayDelayInPayment * daysToDelayPayment;
            totalPayable = amountPayableWithoutPenalty - fine;
        }

        public void changeSer()
        {
            if (serial)
                serial = false;
            else serial = true;
        }

        public void Serializee(BinaryWriter bw)
        {
            int version = serial ? 1 : 0;
            bw.Write(version);
            bw.Write(payPerDay);
            bw.Write(days);
            bw.Write(penaltyFor1DayDelayInPayment);
            bw.Write(daysToDelayPayment);

            if (serial)
            {
                bw.Write(amountPayableWithoutPenalty);
                bw.Write(fine);
                bw.Write(totalPayable);
            }
        }

        public AccountForPayment Deserializee(BinaryReader br)
        {
            int vesion = br.ReadInt32();
            AccountForPayment accDeserial = new AccountForPayment();

            accDeserial.payPerDay = br.ReadInt32();
            accDeserial.days = br.ReadInt32();
            accDeserial.penaltyFor1DayDelayInPayment = br.ReadInt32();
            accDeserial.daysToDelayPayment = br.ReadInt32();

            if (vesion==1)
            {
                accDeserial.amountPayableWithoutPenalty = br.ReadInt32();
                accDeserial.fine = br.ReadInt32();
                accDeserial.totalPayable = br.ReadInt32();
            }
            else
            {
                accDeserial.amountPayableWithoutPenalty=0;
                accDeserial.fine = 0;                                   //единственное до чего додумался это занулить 
                accDeserial.totalPayable = 0;
            }

            return accDeserial;
        }

        public override string ToString()
        {
            return $"payPerDay = {payPerDay}\ndays = {days}\npenaltyFor1DayDelayInPayment = {penaltyFor1DayDelayInPayment}\ndaysToDelayPayment = {daysToDelayPayment}\namountPayableWithoutPenalty = {amountPayableWithoutPenalty}\nfine = {fine}\ntotalPayable = {totalPayable}";
        }

    }
}

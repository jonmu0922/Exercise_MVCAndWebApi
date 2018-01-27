using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DesignPattern.Pattern.Memento
{
    /*
     備忘錄模式
     https://itw01.com/AFHE9K5.html

        從字面意思就可以明白，備忘錄模式就是對某個類的狀態進行儲存下來，等到需要恢復的時候，可以從備忘錄中進行恢復。
        生活中這樣的例子經常看到，如備忘電話通訊錄，備份操作作業系統，備份資料庫等。 
        備忘錄模式的具體定義是：
        在不破壞封裝的前提下，捕獲一個物件的內部狀態，並在該物件之外儲存這個狀態，這樣以後就可以把該物件恢復到原先的狀態。 

        備忘錄模式中主要有三類角色： 
            發起人角色：記錄當前時刻的內部狀態，負責建立和恢復備忘錄資料。 
            備忘錄角色：負責儲存發起人物件的內部狀態，在進行恢復時提供給發起人需要的狀態。 
            管理者角色：負責儲存備忘錄物件。 
    */

    // 聯絡人      
    public class ContactPerson
    {
        public string Name { get ; set ; }
        public string MobileNum { get ; set ; }
    }

    // 發起人      
    public class MobileOwner
    {
        // 發起人需要儲存的內部狀態          
        public List <ContactPerson> ContactPersons { get ; set ; }

        public MobileOwner ( List <ContactPerson> persons )
        {
            ContactPersons = persons ;
        }

        // 建立備忘錄，將當期要儲存的聯絡人列表匯入到備忘錄中          
        public ContactMemento CreateMemento ( )
        {
            return new ContactMemento ( new List <ContactPerson> ( this.ContactPersons ) ) ;
        }

        // 將備忘錄中的資料備份匯入到聯絡人列表中          
        public void RestoreMemento ( ContactMemento memento )
        {
            this.ContactPersons = memento.contactPersonBack ;
        }

        public void Show ( )
        {
            Console.WriteLine ( "聯絡人列表中有{0}個人，他們是:" , ContactPersons.Count );

            foreach ( ContactPerson p in ContactPersons )
            {
                Console.WriteLine ( "姓名: {0} 號碼為: {1}" , p.Name , p.MobileNum ) ;
            }
        }
    }

    // 備忘錄      
    public class ContactMemento
    {
        // 儲存發起人的內部狀態          
        public List <ContactPerson> contactPersonBack ;
        public ContactMemento ( List <ContactPerson> persons )
        {
            contactPersonBack = persons ;
        }
    }

    // 管理角色      
    public class Caretaker
    {
        public ContactMemento ContactM { get ; set ; }
    } 
}

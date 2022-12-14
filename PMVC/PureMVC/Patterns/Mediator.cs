namespace PureMVC.Patterns
{
    using PureMVC.Interfaces;
    using System.Collections.Generic;

    /// <summary>
    /// 视图层
    /// 1.发送与监听消息.
    /// 2监听Component自身的事件，且转化为消息。
    /// 3.设置与调用Component数据与方法。4.直接调用Proxy(推荐尽量少用)。
    /// </summary>
    public class Mediator : Notifier, IMediator
    {
        protected string m_mediatorName;
        protected object m_viewComponent;
        public const string NAME = "Mediator";

        public Mediator() : this("Mediator", null)
        {
        }
        public Mediator(string mediatorName) : this(mediatorName, null)
        {
        }
        public Mediator(string mediatorName, object viewComponent)
        {
            this.m_mediatorName = (mediatorName != null) ? mediatorName : "Mediator";
            this.m_viewComponent = viewComponent;
        }

        /// <summary>
        /// 执行通知事件
        /// </summary>
        /// <param name="notification"></param>
        public virtual void HandleNotification(INotification notification)
        {
        }

        public virtual IList<string> ListNotificationInterests()
        {
            return new List<string>();
        }

        public virtual void OnRegister()
        {
        }

        public virtual void OnRemove()
        {
        }

        public virtual string MediatorName
        {
            get
            {
                return this.m_mediatorName;
            }
        }

        public object ViewComponent
        {
            get
            {
                return this.m_viewComponent;
            }
            set
            {
                this.m_viewComponent = value;
            }
        }
    }
}


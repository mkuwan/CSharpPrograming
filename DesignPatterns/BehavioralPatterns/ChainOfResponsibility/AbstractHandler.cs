using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    internal class AbstractHandler: IHandler
    {
        private IHandler? _nextHandler = null;

        /// <summary>
        /// チェーン先のHandlerにイベントをつなげます
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        /// <summary>
        /// イベントを処理します
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public virtual string? Handle(RequestEvent request)
        {
            return _nextHandler?.Handle(request);
        }
    }
}

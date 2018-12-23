// https://pastebin.com/P4LtiZYb

    ListNode *detectCycle(ListNode* head) {
        if (!head) return nullptr;
        ListNode* slow = head;
        ListNode* quick = head->next;
       
        // find cycle if exists
        while(quick && quick->next && slow != quick) {
            slow = slow->next;
            quick = quick->next->next;
        }
       
        if (slow != quick) return nullptr;
       
        // calc cycle len and move quick pointer from head on the lenght of the cycle
        quick = head;
        auto tmp = slow->next;
        
        while (tmp != slow) {
            tmp = tmp->next;
            quick = quick->next;
        }
        quick = quick->next; // tmp was one step ahead of slow
       
        // move both pointers till they form a loop and meet at the cycle entry
        slow = head;
        while(slow != quick) {
            slow = slow->next;
            quick = quick->next;
        }
       
        return slow;
    }

// https://pastebin.com/RuDP5Sms

/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode *detectCycle(ListNode* head) {
        if (!head) return nullptr;
        auto* slow = head;
        auto* quick = head->next;
       
        // find cycle if exists
        while(quick && quick->next && slow != quick) {
            slow = slow->next;
            quick = quick->next->next;
        }
       
        if (slow != quick) return nullptr;
 
        // move both pointers till they form a loop and meet at the cycle entry
        auto* entry = head;
        slow = slow->next;
        while(slow != entry) {
            slow = slow->next;
            entry = entry->next;
        }
       
        return slow;
    }
};